using DataProvider;
using System;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class BillDAL : ConnectDB
    {
        #region Singleton pattern
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private BillDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetListBillByDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetListBillByDate @dateCheckIn, @dateCheckOut", new object[] { dateCheckIn, dateCheckOut });
        }

        public DataTable GetBillByDateAndPage(DateTime dateCheckIn, DateTime dateCheckOut, int page)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetBillByDateAndPage @dateCheckIn, @dateCheckOut, @page", new object[] { dateCheckIn, dateCheckOut, page });
        }

        public int GetNumBillByDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            object num = SQLQuery.Instance.ExecuteScalar("SP_GetNumBillByDate @dateCheckIn, @dateCheckOut", new object[] { dateCheckIn, dateCheckOut });
            return Convert.ToInt32(num);
        }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable dt = SQLQuery.Instance.ExecuteQuery("SP_GetUncheckBillIDByTableID @idTable", new object[] { id });
            if (dt.Rows.Count > 0)
                return (int)dt.Rows[0]["IdBill"];
            return -1;
        }

        public int InsertBill(int id)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            return (int)SQLQuery.Instance.ExecuteScalar("SP_GetMaxIDBill");
        }

        public void Payment(int id, int discount, double totalPrice)
        {
            SQLQuery.Instance.ExecuteNonQuery("SP_Payment @idBill, @discount, @totalPrice", new object[] { id, discount, totalPrice });
        }
    }
}
