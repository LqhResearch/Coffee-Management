using DataProvider;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class BillInfoDAL : ConnectDB
    {
        #region Singleton pattern
        private static BillInfoDAL instance;
        public static BillInfoDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private BillInfoDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetBillInfoByIdBill(int id)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetBillInfoByIdBill @idBill", new object[] { id });
        }

        public int InsertBillInfo(int idBill, int idTable, int amount)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertBillInfo @idBill, @idTable, @amount", new object[] { idBill, idTable, amount });
        }
    }
}
