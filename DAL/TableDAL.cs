using DataProvider;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class TableDAL : ConnectDB
    {
        #region Singleton pattern
        private static TableDAL instance;
        public static TableDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private TableDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetTable()
        {
            return SQLQuery.Instance.GetTable("TableFood");
        }

        public DataTable SearchTable(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchTable @keyword", new object[] { keyword });
        }

        public bool InsertTable(string nameTable)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertTable @nameTable", new object[] { nameTable }) > 0;
        }

        public bool UpdateTable(int idTable, string nameTable)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_UpdateTable @idTable, @nameTable", new object[] { idTable, nameTable }) > 0;
        }

        public bool DeleteTable(int idTable)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteTable @idTable", new object[] { idTable }) > 0;
        }

        public void SwitchTabel(int id1, int id2)
        {
            SQLQuery.Instance.ExecuteQuery("SP_SwitchTabel @idTable1, @idTable2", new object[] { id1, id2 });
        }

        public void MergeTable(int id1, int id2)
        {
            SQLQuery.Instance.ExecuteQuery("SP_MergeTable @idTable1, @idTable2", new object[] { id1, id2 });
        }
    }
}
