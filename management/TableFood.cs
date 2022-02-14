using CoffeeManagement.DAL;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class TableFood : Form
    {
        #region System
        public TableFood()
        {
            InitializeComponent();
        }
        private void TableFood_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void LoadDataSource()
        {
            dgvTable.DataSource = TableDAL.Instance.GetTable();
            dgvTable.Columns[0].HeaderText = "ID";
            dgvTable.Columns[1].HeaderText = "Tên bàn";
            dgvTable.Columns[2].HeaderText = "Trạng thái bàn";
        }
        #endregion
        #region Event handler properties
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        #endregion
        #region Processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = DrinkDAL.Instance.SearchDrink(txtSearch.Text);
            if (dgvTable.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TableDAL.Instance.InsertTable(txtName.Text))
            {
                MessageBox.Show("Thêm thành công", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else MessageBox.Show("Thêm thất bại", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TableDAL.Instance.UpdateTable(Convert.ToInt32(txtID.Text), txtName.Text))
            {
                MessageBox.Show("Cập nhật thành công", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else MessageBox.Show("Cập nhật thất bại", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvTable.SelectedRows[0].Cells[2].Value.ToString() == "Có người")
            {
                MessageBox.Show("Bạn không thể có bàn đang có khách", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (DrinkDAL.Instance.DeleteDrink(Convert.ToInt32(txtID.Text)))
            {
                MessageBox.Show("Xoá thành công", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else MessageBox.Show("Xoá thất bại", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void dgvTable_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvTable.RowCount + " bàn";
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvTable.SelectedRows[0];
                txtID.Text = row.Cells["IdTable"].Value.ToString();
                txtName.Text = row.Cells["NameTable"].Value.ToString();
                ckbStatusTable.Checked = (row.Cells["StatusTable"].Value.ToString() == "Có người");
            }
        }
    }
}
