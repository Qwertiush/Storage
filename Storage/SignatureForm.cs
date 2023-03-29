using System.Drawing.Imaging;

namespace Storage
{
    public partial class SignatureForm : Form
    {
        private string barCode;

        Pen pen;
        Bitmap bmp;
        bool isDrawing;

        public SignatureForm(string code)
        {
            InitializeComponent();
            barCode = code;

            bmp = new Bitmap(signatureBox.ClientSize.Width,signatureBox.ClientSize.Height);
            pen = new Pen(Color.Black, 5);
            isDrawing = false;

        }

        private void UpdateItemData(string path)
        {
            StorageDataBase dB = new StorageDataBase();
            if(dB.CheckIfItemExists(barCode))
            {
                if(dB.CheckItemsStatus(barCode) == "1")
                {
                    dB.UpdateItemInfo(barCode, 0, path, false);
                }
                else
                {
                    dB.UpdateItemInfo(barCode, 1, path, true);
                }
            }
        }

        private string CreateSignaturePath()
        {
            string result = @"D:\Signatures\error.png";
            string path2Folder = @"D:\Signatures\";
            DateTime now = DateTime.Now;
            result = path2Folder + barCode+"-"+ now.Year.ToString() + "-" + now.Month.ToString() + "-" + now.Day.ToString() + "-" + now.Hour.ToString() + "-" + now.Minute.ToString() + "-" + now.Second.ToString() + ".bmp";

            return result;
        }

        private void applayBTNSignaForm_Click(object sender, EventArgs e)
        {
            string path = CreateSignaturePath();
            UpdateItemData(path);
            //save the signature
            bmp.Save(path);

            this.Close();
        }

        private void cancelBTNSignaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignatureForm_Load(object sender, EventArgs e)
        {

        }

        private void signatureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void signatureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawRectangle(pen, e.X, e.Y, 1, 1);
                signatureBox.Image = bmp;
            }
        }

        private void signatureBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signatureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void signatureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
