using DataProvider;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class CategoryDAL : ConnectDB
    {
        #region Singleton pattern
        private static CategoryDAL instance;
        public static CategoryDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private CategoryDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetTable()
        {
            return SQLQuery.Instance.GetTable("Category");
        }

        public DataTable SearchCategory(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchCategory @keyword", new object[] { keyword });
        }

        public bool InsertCategory(string nameCategory)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertCategory @nameCategory", new object[] { nameCategory }) > 0;
        }

        public bool UpdateCategory(int idCategory, string nameCategory)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_UpdateCategory @idCategory, @nameCategory", new object[] { idCategory, nameCategory }) > 0;
        }

        public bool DeleteCategory(int idCategory)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteCategory @idCategory", new object[] { idCategory }) > 0;
        }
    }
}
