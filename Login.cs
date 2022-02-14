using CoffeeManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.isLogin(txtUsername.Text, txtPassword.Text))
            {
                DataRow row = AccountDAL.Instance.GetAccountByUsername(txtUsername.Text);
                Main main = new Main(row);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPass.Checked;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
}
