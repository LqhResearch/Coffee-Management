using CoffeeManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Bill : Form
    {
        #region Properties
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        #endregion
        #region System
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);

            btnStatistical_Click(null, null);
            btnFirstPage_Click(null, null);
            ShowBillByDateAndPage();
        }
        #endregion
        #region Common function
        private void ShowBillByDateAndPage()
        {
            txtCurrentPage.Text = CurrentPage + "/" + TotalPage;
            dgvBill.DataSource = BillDAL.Instance.GetBillByDateAndPage(dtpFromDate.Value, dtpToDate.Value, CurrentPage);
        }

        private void ChangeEnabledOfButtons()
        {
            btnFirstPage.Enabled = btnPrevPage.Enabled = true;
            btnLastPage.Enabled = btnNextPage.Enabled = true;

            if(CurrentPage == 1)
                btnFirstPage.Enabled = btnPrevPage.Enabled = false;
            if (CurrentPage == TotalPage)
                btnLastPage.Enabled = btnNextPage.Enabled = false;
        }
        #endregion
        #region Processing
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            TotalPage = (int)Math.Ceiling(BillDAL.Instance.GetNumBillByDate(dtpFromDate.Value, dtpToDate.Value) / 10.0);
            btnFirstPage_Click(null, null);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Change page
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            ShowBillByDateAndPage();
            ChangeEnabledOfButtons();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            ShowBillByDateAndPage();
            ChangeEnabledOfButtons();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            ShowBillByDateAndPage();
            ChangeEnabledOfButtons();
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            CurrentPage = TotalPage;
            ShowBillByDateAndPage();
            ChangeEnabledOfButtons();
        }
        #endregion
    }
}
