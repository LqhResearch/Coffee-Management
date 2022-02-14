using CoffeeManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Drink : Form
    {
        #region System
        public Drink()
        {
            InitializeComponent();
        }

        private void Drink_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = CategoryDAL.Instance.GetTable();
            cboCategory.DisplayMember = "NameCategory";
            cboCategory.ValueMember = "IdCategory";
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void LoadDataSource()
        {
            dgvDrink.DataSource = DrinkDAL.Instance.GetTable();
            dgvDrink.Columns[0].HeaderText = "ID";
            dgvDrink.Columns[1].HeaderText = "Tên đồ uống";
            dgvDrink.Columns[2].HeaderText = "Giá";
            dgvDrink.Columns[3].HeaderText = "ID danh mục";
        }
        #endregion
        #region Event handler properties
        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }
        #endregion
        #region Processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDrink.DataSource = DrinkDAL.Instance.SearchDrink(txtSearch.Text);
            if (dgvDrink.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DrinkDAL.Instance.InsertDrink(txtName.Text, (double)nudNumDrink.Value, Convert.ToInt32(cboCategory.SelectedValue)))
            {
                MessageBox.Show("Thêm thành công", "Thức uống", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else MessageBox.Show("Thêm thất bại", "Thức uống", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DrinkDAL.Instance.UpdateDrink(Convert.ToInt32(txtID.Text), txtName.Text, (double)nudNumDrink.Value, Convert.ToInt32(cboCategory.SelectedValue)))
            {
                MessageBox.Show("Cập nhật thành công", "Thức uống", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (updateDrink != null)
                    updateDrink(this, new EventArgs());
            }
            else MessageBox.Show("Cập nhật thất bại", "Thức uống", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DrinkDAL.Instance.DeleteDrink(Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Xoá thành công", "Thức uống", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else MessageBox.Show("Xoá thất bại", "Thức uống", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void dgvDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDrink.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDrink.SelectedRows[0];
                txtID.Text = row.Cells["IdDrink"].Value.ToString();
                txtName.Text = row.Cells["NameDrink"].Value.ToString();
                nudNumDrink.Value = Convert.ToInt32(row.Cells["PriceDrink"].Value);
                cboCategory.SelectedValue = row.Cells["IdCategory"].Value.ToString();
            }
        }

        private void dgvDrink_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDrink.RowCount + " đồ uống";
        }
    }
}
