using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            statusComBoxdataF.Items.AddRange(new object[] {
                "All",
                "In Storage [1]",
                "Given      [0]"
            });
            statusComBoxdataF.SelectedIndex = 0;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            StorageDataBase dB = new StorageDataBase();
            dB.ShowDatabase(dataGridView1);
        }

        private void backBTNDataF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTNDataF_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBTNDataF_Click(object sender, EventArgs e)
        {
            StorageDataBase dB = new StorageDataBase();
            dB.SearchNameOrBarcode(nameTxTBoxDataF.Text,statusComBoxdataF.SelectedIndex, dataGridView1);
        }
    }
}
