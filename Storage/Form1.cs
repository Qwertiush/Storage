using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Windows.Compatibility;

namespace Storage
{
    public partial class Form1 : Form
    {
        //varriables for video capture
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get info about pluged in cameras
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
            {
                camerasComBox.Items.Add(device.Name);
            }
            camerasComBox.SelectedIndex = 0;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //scaning frame
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
            StorageDataBase dB = new StorageDataBase();
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop();
            }
            if (dB.CheckIfItemExists(barcodeTxT.Text))
            {
                SignatureForm form = new SignatureForm(barcodeTxT.Text);
                form.Show();
            }
            else
            {
                TextBox textBox = new TextBox();
                textBox.Size = new Size(100, 100);
                Help.ShowPopup(textBox, "BarCode doesn't exist in database", new Point(this.Location.X + 200, this.Location.Y + 200));
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            StorageDataBase db = new StorageDataBase();

            if(db.CheckIfItemExists(barcodeTxT.Text))
            {
                TextBox textBox = new TextBox();
                textBox.Size = new Size(100, 100);
                Help.ShowPopup(textBox, "Already in database", new Point(this.Location.X + 200, this.Location.Y + 200));
            }
            else
            {
                Form2 form2 = new Form2(barcodeTxT.Text);
                form2.Show();
            }
        }

        private void dataBTN_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm();
            form.Show();
        }
    }
}