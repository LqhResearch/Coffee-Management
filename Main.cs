using CoffeeManagement.DAL;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Main : Form
    {
        #region Properties
        public DataRow LoginAccount { get; set; }
        #endregion
        #region System
        public Main(DataRow loginAccount)
        {
            InitializeComponent();
            LoginAccount = loginAccount;
            tsmiManage.Enabled = (LoginAccount["Access"].ToString() == "Admin");
            tsmiAccountProfile.Text += (LoginAccount["DisplayName"].ToString() == "")
                                            ? " (" + LoginAccount["Username"] + ")"
                                            : " (" + LoginAccount["DisplayName"] + ")";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxDrink();
            LoadComboBoxTable();
        }
        #endregion
        #region Common function
        private void LoadTable()
        {
            DataTable dt = TableDAL.Instance.GetTable();

            fpnlTableList.Controls.Clear();
            foreach (DataRow item in dt.Rows)
            {
                Guna2Button btn = new Guna2Button();
                btn.FillColor = Color.Transparent;
                btn.Font = new Font("Segoe UI", 9.75F);
                btn.ForeColor = Color.Black;
                btn.Image = (item["StatusTable"].ToString() == "Trống") ? Properties.Resources.coffee_null : Properties.Resources.coffee_cup;
                btn.ImageOffset = new Point(0, -15);
                btn.ImageSize = new Size(60, 60);
                btn.Size = new Size(Content.tableWidth, Content.tableHeight);
                btn.Tag = item;
                btn.Text = item["NameTable"] + "\n" + item["StatusTable"];
                btn.TextAlign = HorizontalAlignment.Left;
                btn.TextOffset = new Point(0, 30);
                btn.Click += Btn_Click;

                fpnlTableList.Controls.Add(btn);
            }
        }

        private void LoadComboBoxDrink()
        {
            cboCategory.DataSource = CategoryDAL.Instance.GetTable();
            cboCategory.DisplayMember = "NameCategory";
            cboCategory.ValueMember = "IdCategory";
            cboCategory_SelectedIndexChanged(null, null);
        }

        private void LoadComboBoxTable()
        {
            cboSwitchTable.DataSource = TableDAL.Instance.GetTable();
            cboSwitchTable.DisplayMember = "NameTable";
            cboSwitchTable.ValueMember = "IdTable";

            cboMergeTable.DataSource = TableDAL.Instance.GetTable();
            cboMergeTable.DisplayMember = "NameTable";
            cboMergeTable.ValueMember = "IdTable";
        }

        private void ShowBill(int id)
        {
            int idBill = BillDAL.Instance.GetUncheckBillIDByTableID(id);
            dgvBillInfo.DataSource = BillInfoDAL.Instance.GetBillInfoByIdBill(idBill);

            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture; Áp dụng thay đổi cả Thread
            txtTotalPrice.Text = TotalPrice().ToString("c", culture);
        }

        private int TotalPrice()
        {
            int sum = 0;
            for (int i = 0; i < dgvBillInfo.RowCount; i++)
                sum += Convert.ToInt32(dgvBillInfo.Rows[i].Cells["Thành tiền"].Value);
            return sum;
        }

        private void LoadInsEditDel_Drink()
        {
            int id;
            if (!Int32.TryParse(cboCategory.SelectedValue.ToString(), out id))
                return;
            cboDrink.DataSource = DrinkDAL.Instance.GetDrinkByIdCategory(id);
            if (dgvBillInfo.Tag != null)
                ShowBill(Convert.ToInt32((dgvBillInfo.Tag as DataRow)["IdTable"]));
        }
        #endregion
        #region Menu strip
        private void tsmiBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.ShowDialog();
        }

        private void tsmiTableDrink_Click(object sender, EventArgs e)
        {
            TableFood table = new TableFood();
            table.InsertTable += Table_InsertTable;
            table.UpdateTable += Table_UpdateTable;
            table.DeleteTable += Table_DeleteTable;
            table.ShowDialog();
        }

        private void tsmiCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.InsertCategory += Category_InsertCategory;
            category.UpdateCategory += Category_UpdateCategory;
            category.DeleteCategory += Category_DeleteCategory;
            category.ShowDialog();
        }

        private void tsmiDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            drink.InsertDrink += Drink_InsertDrink;
            drink.UpdateDrink += Drink_UpdateDrink;
            drink.DeleteDrink += Drink_DeleteDrink;
            drink.ShowDialog();
        }

        private void tsmiAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account(LoginAccount);
            account.ShowDialog();
        }

        private void tsmiAccountProfile_Click(object sender, EventArgs e)
        {
            AccountProfile profile = new AccountProfile(LoginAccount);
            profile.UpdateAccount += Profile_UpdateAccount;
            profile.ShowDialog();
        }

        private void tsmiAddNumDrink_Click(object sender, EventArgs e)
        {
            btnAddNumDrink_Click(this, new EventArgs());
        }

        private void tsmiSwitchTable_Click(object sender, EventArgs e)
        {
            btnSwitchTable_Click(this, new EventArgs());
        }

        private void tsmiMergeTable_Click(object sender, EventArgs e)
        {
            btnMergeTable_Click(this, new EventArgs());
        }

        private void tsmiPayment_Click(object sender, EventArgs e)
        {
            btnPayment_Click(this, new EventArgs());
        }
        #endregion
        #region Event Handler
        private void Profile_UpdateAccount(object sender, AccountEvent e)
        {
            LoginAccount = e.LoginAcc;
            tsmiAccountProfile.Text = (LoginAccount["DisplayName"].ToString() == "")
                                            ? "&Thông tin tài khoản (" + LoginAccount["Username"] + ")"
                                            : "&Thông tin tài khoản (" + LoginAccount["DisplayName"] + ")";
        }

        private void Table_InsertTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void Table_UpdateTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void Table_DeleteTable(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void Category_InsertCategory(object sender, EventArgs e)
        {
            LoadComboBoxDrink();
        }

        private void Category_UpdateCategory(object sender, EventArgs e)
        {
            LoadComboBoxDrink();
        }

        private void Category_DeleteCategory(object sender, EventArgs e)
        {
            LoadComboBoxDrink();
        }

        private void Drink_InsertDrink(object sender, EventArgs e)
        {
            LoadInsEditDel_Drink();
        }

        private void Drink_UpdateDrink(object sender, EventArgs e)
        {
            LoadInsEditDel_Drink();
        }

        private void Drink_DeleteDrink(object sender, EventArgs e)
        {
            LoadInsEditDel_Drink();
            LoadTable();
        }
        #endregion
        #region Processing
        private void Btn_Click(object sender, EventArgs e)
        {
            DataRow row = (sender as Guna2Button).Tag as DataRow;
            dgvBillInfo.Tag = (sender as Guna2Button).Tag;

            ShowBill(Convert.ToInt32(row["IdTable"]));
            grbSelectedTable.Text = row["NameTable"].ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DataRow row = dgvBillInfo.Tag as DataRow;

            int idBill = BillDAL.Instance.GetUncheckBillIDByTableID(Convert.ToInt32(row["IdTable"]));
            if (idBill != -1)
            {
                int discount = (int)nudDiscount.Value;
                int totalPrice = Convert.ToInt32(txtTotalPrice.Text.Split(',')[0].Replace(".", ""));
                int finalTotalPrice = totalPrice - (int)(totalPrice / 100 * discount);

                string msg = "Bạn có chắc chắn muốn thanh toán " + row["NameTable"] +
                    "\nGiảm giá: " + discount + "%" +
                    "\nTổng tiền = Tổng tiền - Giảm giá = " + totalPrice + " - " + (int)(totalPrice / 100 * discount) + " = " + finalTotalPrice;

                if (MessageBox.Show(msg, "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    BillDAL.Instance.Payment(idBill, (int)nudDiscount.Value, finalTotalPrice);
                    ShowBill(Convert.ToInt32(row["IdTable"]));
                    LoadTable();
                }
            }
        }

        private void btnAddNumDrink_Click(object sender, EventArgs e)
        {
            DataRow row = dgvBillInfo.Tag as DataRow;
            if (row == null)
            {
                MessageBox.Show("Hãy chọn bàn trước khi thêm đồ uống", "Quản lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBill = BillDAL.Instance.GetUncheckBillIDByTableID(Convert.ToInt32(row["IdTable"]));
            int idDrink = Convert.ToInt32(cboDrink.SelectedValue);
            int amount = (int)nudNumDrink.Value;
            if (amount == 0) return;

            if (idBill == -1) // Bàn này chưa có bill
            {
                BillDAL.Instance.InsertBill(Convert.ToInt32(row["IdTable"]));
                BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxIDBill(), idDrink, amount);
            }
            else
                BillInfoDAL.Instance.InsertBillInfo(idBill, idDrink, amount);

            ShowBill(Convert.ToInt32(row["IdTable"]));
            LoadTable();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            DataRow row = dgvBillInfo.Tag as DataRow;
            int id1 = Convert.ToInt32(row["IdTable"]);
            int id2 = Convert.ToInt32(cboSwitchTable.SelectedValue);

            DialogResult result = MessageBox.Show("Bạn có thật sự muốn chuyển từ " + row["NameTable"] + " sang " + cboSwitchTable.Text + " không?", "Chuyển bàn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                TableDAL.Instance.SwitchTabel(id1, id2);
            LoadTable();
            ShowBill(id1);
        }

        private void btnMergeTable_Click(object sender, EventArgs e)
        {
            DataRow row = dgvBillInfo.Tag as DataRow;
            int id1 = Convert.ToInt32(row["IdTable"]);
            int id2 = Convert.ToInt32(cboMergeTable.SelectedValue);

            DialogResult result = MessageBox.Show("Bạn có thật sự muốn gộp từ " + row["NameTable"] + " sang " + cboMergeTable.Text + " không?", "Gộp bàn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                TableDAL.Instance.MergeTable(id1, id2);
            LoadTable();
            ShowBill(id1);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(cboCategory.SelectedValue.ToString(), out id))
                return;

            cboDrink.DataSource = DrinkDAL.Instance.GetDrinkByIdCategory(id);
            cboDrink.DisplayMember = "NameDrink";
            cboDrink.ValueMember = "IdDrink";
        }
    }
}
