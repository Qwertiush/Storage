
namespace Storage
{
    public partial class Form2 : Form
    {
        private string barcodeTxT;

        public Form2(string codeTxT)
        {
            InitializeComponent();
            barcodeTxT = codeTxT;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            codeTxTBoxF2.Text = barcodeTxT;
        }

        private void addBTNF2_Click(object sender, EventArgs e)
        {
            StorageDataBase db = new StorageDataBase();
            db.AddItemToDatabase(nameTxTBoxF2.Text, codeTxTBoxF2.Text);
            this.Close();
        }

        private void cancelBTNF2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
