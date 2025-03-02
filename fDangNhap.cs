using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySan
{
    public partial class fDangNhap: Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            fQuanLySan f = new fQuanLySan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
                if(MessageBox.Show("Bạn có thậ sự muốn thoát?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
