using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA201207_2
{
    public partial class FrmMain : Form
    {

        OleDbConnection conn;

        public FrmMain()
        {
            conn = new OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=|DataDirectory|Resources\utiroda.accdb");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
