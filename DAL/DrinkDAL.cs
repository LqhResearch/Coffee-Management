using DataProvider;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class DrinkDAL : ConnectDB
    {
        #region Singleton pattern
        private static DrinkDAL instance;
        public static DrinkDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DrinkDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private DrinkDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetTable()
        {
            return SQLQuery.Instance.GetTable("Drink");
        }

        public DataTable GetDrinkByIdCategory(int id)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetDrinkByIdCategory @idCategory", new object[] { id });
        }

        public DataTable SearchDrink(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchDrink @keyword", new object[] { keyword });
        }

        public bool InsertDrink(string nameDrink, double priceDrink, int idCategory)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertDrink @nameDrink, @priceDrink, @idCategory", new object[] { nameDrink, priceDrink, idCategory }) > 0;
        }

        public bool UpdateDrink(int idDrink, string nameDrink, double priceDrink, int idCategory)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_UpdateDrink @idDrink, @nameDrink, @priceDrink, @idCategory", new object[] { idDrink, nameDrink, priceDrink, idCategory }) > 0;
        }

        public bool DeleteDrink(int idDrink)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteDrink @idDrink", new object[] { idDrink }) > 0;
        }
    }
}
