using CoffeeManagement.DAL;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Category : Form
    {
        #region System
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void LoadDataSource()
        {
            dgvCategory.DataSource = CategoryDAL.Instance.GetTable();
            dgvCategory.Columns[0].HeaderText = "ID";
            dgvCategory.Columns[1].HeaderText = "Tên danh mục";
        }
        #endregion
        #region Event handler properties
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        #endregion
        #region Processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource = CategoryDAL.Instance.SearchCategory(txtSearch.Text);
            if (dgvCategory.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CategoryDAL.Instance.InsertCategory(txtName.Text))
            {
                MessageBox.Show("Thêm thành công", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else MessageBox.Show("Thêm thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CategoryDAL.Instance.UpdateCategory(Convert.ToInt32(txtID.Text), txtName.Text))
            {
                MessageBox.Show("Cập nhật thành công", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else MessageBox.Show("Cập nhật thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Khi bạn nhấn OK thì tất cả thức uống thuộc danh mục này sẽ bị sẽ xoá theo", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                if (CategoryDAL.Instance.DeleteCategory(Convert.ToInt32(txtID.Text)))
                {
                    MessageBox.Show("Xoá thành công", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    LoadDataSource();
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());
                }
                else MessageBox.Show("Xoá thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategory.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvCategory.SelectedRows[0];
                txtID.Text = row.Cells["IdCategory"].Value.ToString();
                txtName.Text = row.Cells["NameCategory"].Value.ToString();
            }
        }

        private void dgvCategory_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvCategory.RowCount + " danh mục";
        }
    }
}
