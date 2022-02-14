using CoffeeManagement.DAL;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Account : Form
    {
        #region Properties
        public DataRow LoginAccount { get; set; }
        #endregion
        #region System
        public Account(DataRow loginAccount)
        {
            InitializeComponent();
            LoginAccount = loginAccount;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void LoadDataSource()
        {
            dgvAccount.DataSource = AccountDAL.Instance.GetAccount();
        }

        private string EncodeStringToMD5(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //Array.Reverse(hasData);
            string hasPass = "";
            foreach (byte item in hasData)
                hasPass += item;
            return hasPass;
        }
        #endregion
        #region Event handler properties
        private event EventHandler insertAccount;
        public event EventHandler InsertAccount
        {
            add { insertAccount += value; }
            remove { insertAccount -= value; }
        }

        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private event EventHandler deleteAccount;
        public event EventHandler DeleteAccount
        {
            add { deleteAccount += value; }
            remove { deleteAccount -= value; }
        }
        #endregion
        #region Processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = AccountDAL.Instance.SearchAccount(txtSearch.Text);
            if (dgvAccount.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.InsertAccount(txtUsername.Text, txtDisplayName.Text, cboAccess.Text))
            {
                MessageBox.Show("Thêm thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (insertAccount != null)
                    insertAccount(this, new EventArgs());
            }
            else MessageBox.Show("Thêm thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.EditAccount(txtUsername.Text, txtDisplayName.Text, cboAccess.Text))
            {
                MessageBox.Show("Cập nhật thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (updateAccount != null)
                    updateAccount(this, new EventArgs());
            }
            else MessageBox.Show("Cập nhật thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(LoginAccount["Username"].ToString() == txtUsername.Text)
            {
                MessageBox.Show("Bạn không thể xoá tài khoản đang đăng nhập", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AccountDAL.Instance.DeleteAccount(txtUsername.Text))
            {
                MessageBox.Show("Xoá thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (deleteAccount != null)
                    deleteAccount(this, new EventArgs());
            }
            else MessageBox.Show("Xoá thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.ResetPassword(txtUsername.Text))
                MessageBox.Show("Thiết lập lại mật khẩu thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else MessageBox.Show("Thiết lập lại mật khẩu thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                cboAccess.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvAccount_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvAccount.RowCount + " tài khoản";
        }
    }
}
