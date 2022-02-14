using DataProvider;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class AccountDAL : ConnectDB
    {
        #region Singleton pattern
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetAccount()
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetAccount");
        }

        public bool isLogin(string username, string password)
        {
            int num = (int)SQLQuery.Instance.ExecuteScalar("SP_IsLogin @username, @password", new object[] { username, password });
            return num > 0;
        }

        public DataRow GetAccountByUsername(string username)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetAccountByUsername @username", new object[] { username }).Rows[0];
        }

        public bool UpdateAccount(string username, string displayName, string password, string newPassword)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_UpdateAccount @username, @displayName, @password, @newPassword", new object[] { username, displayName, password, newPassword }) > 0;
        }

        public DataTable SearchAccount(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchAccount @keyword", new object[] { keyword });
        }

        public bool InsertAccount(string username, string displayName, string access)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertAccount @username, @displayName, @access", new object[] { username, displayName, access }) > 0;
        }

        public bool EditAccount(string username, string displayName, string access)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_EditAccount @username, @displayName, @access", new object[] { username, displayName, access }) > 0;
        }

        public bool DeleteAccount(string username)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteAccount @username", new object[] { username }) > 0;
        }

        public bool ResetPassword(string username)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_ResetPassword @username", new object[] { username }) > 0;
        }
    }
}
