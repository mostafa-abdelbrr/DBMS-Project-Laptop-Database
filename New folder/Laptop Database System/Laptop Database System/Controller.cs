using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Laptop_Database_System
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public int checkUser(string username, string password) // checks if the user exists in the DB or not
        {
            string query = @"select ID
                            from S_User
                            where CONVERT(NVARCHAR(MAX), UserName) = N'" + username + @"'
                            AND
                            CONVERT(NVARCHAR(MAX), Password) = N'" + password + "'";

            if (dbMan.ExecuteScalar(query) == null)
            {
                return -1; // user not found
            }

            return (int)dbMan.ExecuteScalar(query);

        }

        public int getUserDataFromID(int id, ref string username, ref string role)
        {
            username = "n/a";
            role = "n/a";
            string nameQuery = " select UserName from S_User where ID = '" + id + "'";
            string roleQuery = " select Role from S_User where ID = '" + id + "'";

            username = (string) dbMan.ExecuteScalar(nameQuery);
            role = (string) dbMan.ExecuteScalar(roleQuery);

            return 0;


        }

        public int getNewID()
        {
            return (int) dbMan.ExecuteScalar("select max(ID)+1 from S_User ");
        }

        public int signUp(string email,string username,string password,bool consent,string role)
        {
            string _consent ;

            if (consent)
            {
                _consent = "1";
            } else
            {
                _consent = "0";
            }

            int ID = getNewID();
            
            string query = "INSERT INTO S_User Values("+ID.ToString()+",'"+email +"',' "+username+"','"+role+"',"+_consent+",'"+password+"')";
            return dbMan.ExecuteNonQuery(query);
        }

    }
}
