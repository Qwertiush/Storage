using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Windows.Compatibility;

namespace Storage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
            {
                camerasComBox.Items.Add(device.Name);
            }
            camerasComBox.SelectedIndex = 0;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                barcodeTxT.Invoke(new MethodInvoker(delegate ()
                {
                    barcodeTxT.Text = result.ToString();
                }));
            }

            barcodePicBox.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                }
            }
        }

        private void startCapturBTN_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[camerasComBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void goToSignatureBTN_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.SignalToStop();
        }
    }
}