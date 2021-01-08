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


        public int checkUser(string username, string password) // checks if the user exists in the DB or not and returns their ID
        {
            string query = "select ID from S_User where  UserName COLLATE SQL_Latin1_General_CP1_CS_AS = N'" + username + @"' AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = N'" + password + "'";

            if (dbMan.ExecuteScalar(query) == null)
            {
                return -1; // user not found
            }

            return (int)dbMan.ExecuteScalar(query);

        }

        public int checkUser(string username) // checks if the user exists in the DB or not and returns their ID
        {
            string query = "select ID from S_User where  UserName COLLATE SQL_Latin1_General_CP1_CS_AS = N'" + username + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return -1; // user not found
            }

            return (int)dbMan.ExecuteScalar(query);

        }



        public int checkMail(string email) // checks if the email exists in the DB or not and returns their ID
        {
            string query = "select ID from S_User where  email ='" + email + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return -1; // user not found
            }

            return (int)dbMan.ExecuteScalar(query);

        }

        public string checkStorePhone(long phone) // checks if the phone number exists in the DB or not 
        {
            string query = "select Name from Store where Phone ='" + phone + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "N/A"; // store not found
            }

            return (string)dbMan.ExecuteScalar(query);

        }

        public string checkStoreAddress(string address) // checks if the address exists in the DB or not 
        {
            string query = "select Name from Store where Address ='" + address + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "N/A"; // store not found
            }

            return (string)dbMan.ExecuteScalar(query);

        }


        public string checkStoreName(string name) // checks if the address exists in the DB or not 
        {
            string query = "select Name from Store where Name ='" + name + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "N/A"; // store not found
            }

            return (string)dbMan.ExecuteScalar(query);

        }

        public int addToRam(string ram,string ddr, string model )
        {
            string query = "INSERT INTO RAM VALUES ('"+ram+"','"+ddr+"','"+model+"')";
            return dbMan.ExecuteNonQuery(query);
        }


        public int getUserDataFromID(int id, ref string username, ref string role)
        {
            username = "n/a";
            role = "n/a";

            if (id == -1)
            {
                return -1;
            }

            string nameQuery = " select UserName from S_User where ID = '" + id + "'";
            string roleQuery = " select Role from S_User where ID = '" + id + "'";

            username = (string)dbMan.ExecuteScalar(nameQuery);
            role = (string)dbMan.ExecuteScalar(roleQuery);

            return checkUser(username);


        }
        public int addToLaptop(string modelNum, string name, string date)
        {

            string query = "INSERT INTO Laptop Values('" + modelNum + "','" + name + "','" + date + "',0,0)";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillManufacturerComboBox()
        {
            string query = "Select Name From Manufacturer_Data";
            return dbMan.ExecuteReader(query);
        }

        public int addToManufacturer(string maker, string model, string date)
        {
            string query = "INSERT INTO Manufacturered_By Values ('" + maker + "','" + model + "','" + date + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillProcMaker()
        {
            string query = "SELECT Distinct Brand from Processor";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillGFXMaker()
        {
            string query = "SELECT DISTINCT Manufacturer from Graphics_Card";
            return dbMan.ExecuteReader(query);
        }

        public AutoCompleteStringCollection getProcModelAutoCompSrc(string brand)
        {
            string query = "Select ModelNum From Processor Where Brand = '" + brand + "'";
            DataTable dt = new DataTable();
            dt = dbMan.ExecuteReader(query);

            AutoCompleteStringCollection autolist = new AutoCompleteStringCollection();

            foreach (DataRow r in dt.Rows)
            {
                autolist.Add(r[0].ToString());
            }
            return autolist;
        }

        public AutoCompleteStringCollection getGFXModelAutoCompSrc(string mfc)
        {
            string query = "Select Model_Number From Graphics_Card Where Manufacturer = '" + mfc + "'";
            DataTable dt = new DataTable();
            dt = dbMan.ExecuteReader(query);

            AutoCompleteStringCollection autolist = new AutoCompleteStringCollection();

            foreach (DataRow r in dt.Rows)
            {
                autolist.Add(r[0].ToString());
            }
            return autolist;
        }

        public DataTable checkProc(string brand, string model)
        {
            string query = "SELECT Brand,ModelNum FROM Processor Where Brand = '" + brand + "' AND ModelNum = '" + model + "'";
            return dbMan.ExecuteReader(query);
        }

        public string checkLaptopModel(string model)
        {
            string query = "select Model from Laptop where Model ='" + model + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "N/A"; // store not found
            }

            return (string)dbMan.ExecuteScalar(query);

        }
        public string getOwner(string id)
        {
            string query = "Select Store_Name from Owner where User_ID =  " + id;
            return (string)dbMan.ExecuteScalar(query);
        }

        public string checkLaptopName(string name)
        {
            string query = "select Name from Laptop where Name ='" + name + "'";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return "N/A"; // store not found
            }

            return (string)dbMan.ExecuteScalar(query);

        }


        public int addToBoughtFrom(string model, string store, string price, string stock)
        {
            string query = "INSERT INTO Bought_From VALUES('" + model + "','" + store + "','" + price + "','" + stock + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        


        public long getNewID()
        {
            if (dbMan.ExecuteScalar("select max(ID)+1 from S_User") == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt64(dbMan.ExecuteScalar("select max(ID)+1 from S_User"));
        }

        public int signUp(string email, string username, string password, bool consent, string role)
        {
            string _consent;

            if (consent)
            {
                _consent = "1";
            }
            else
            {
                _consent = "0";
            }

            long ID = getNewID();

            string query = "INSERT INTO S_User Values(" + ID.ToString() + ",'" + email + "','" + username + "','" + role + "'," + _consent + ",'" + password + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addStore(string name, long number, string address)
        {
            string query = "INSERT INTO Store Values('" + name + "'," + number + ",'" + address + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addStoreOwner(string storeName, int id)
        {
            string query = "INSERT INTO Owner Values (" + id + ",'" + storeName + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public string getEmail(int ID)
        {
            string email;
            email = (string)dbMan.ExecuteScalar("select email from S_user where ID =" + ID + "");
            return email;
        }

        public string getPassword(int ID)
        {
            string password;
            password = (string)dbMan.ExecuteScalar("select Password from S_user where ID =" + ID + "");
            return password;
        }

        public string getStoreName(int ID)
        {
            string name;
            name = (string)dbMan.ExecuteScalar("select Name from Store,Owner where User_ID =" + ID + "AND Name = Store_Name");
            return name;
        }

        public string getStoreAddress(int ID)
        {
            string Address;
            Address = (string)dbMan.ExecuteScalar("select Address from Store,Owner where User_ID =" + ID + "AND Name = Store_Name");
            return Address;
        }
        public long getStoreNumber(int ID)
        {
            long num;
            num = (Int64)dbMan.ExecuteScalar("select Phone from Store,Owner where User_ID =" + ID + "AND Name = Store_Name");
            return num;
        }

        public bool getConsent(int ID)
        {
            bool con;
            con = (bool)dbMan.ExecuteScalar("select DataShareConsent from S_user where ID =" + ID + "");


            return con;

        }

        public int editUser(int id, string username, string password, string email, int consent)
        {
            string query = "update S_User set UserName = '" + username + "'," +
                           "password = '" + password + "'," +
                           "dataShareConsent = " + consent + "," +
                           "email = '" + email + "'" +
                           "where ID = " + id + "";


            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getall()
        {
            string query = "Select * from Laptop"; // TODO: Add a select all feature
            return dbMan.ExecuteReader(query);
        }

        public DataTable getlaptopbyfeatures(string lname, string ktype, string klight,
                                             string cpubrand, string cpumodel, string ramsize,
                                             string ramddr, string gpumodel, string os, string ssize,
                                             string smanufacturer, string sctype, string scres, string scsize)
        {

            /* this block just checks if the passed argument is empty and replaces it with the wildcard "*",
               otherwise it uses the same stored value */
            lname = lname == "" ? "*" : lname;
            ktype = ktype == "" ? "*" : ktype;
            klight = klight == "" ? "*" : klight;
            cpubrand = cpubrand == "" ? "*" : cpubrand;
            cpumodel = cpumodel == "" ? "*" : cpumodel;
            ramsize = ramsize == "" ? "*" : ramsize;
            ramddr = ramddr == "" ? "*" : ramddr;
            gpumodel = gpumodel == "" ? "*" : gpumodel;
            os = os == "" ? "*" : os;
            ssize = ssize == "" ? "*" : ssize;
            smanufacturer = smanufacturer == "" ? "*" : smanufacturer;
            sctype = sctype == "" ? "*" : sctype;
            scres = scres == "" ? "*" : scres;
            scsize = scsize == "" ? "*" : scsize;

            string query = "Select * from Laptop l, Composed_of c where l.Name like '" + lname
                + "' and c.Laptop_Model = l.Model and c.K_Type = '" + ktype + "' and c.K_Light = '" + klight
                + "'and c.P_Brand = '" + cpubrand + "' and c.P_ModelNum = '" + cpumodel + "' and c.R_Size = '" + ramsize
                + "' and c.R_DDR = '" + ramddr + "' and c.GPU_Model_Number = '" + gpumodel + "' and c.OS_Name = '" + os
                + "'and c.S_Size = '" + ssize + "' and c.S_Manufacturer = '" + smanufacturer + "' and c.SC_Type = '" + sctype
                + "'and c.SC_Resolution ='" + scres + "' and c.SC_Size = '" + scsize + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getramsize()
        {
            string query = "Select Size from RAM";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SortMostSearched()
        {
            string query = "select Laptop_Model,count(Laptop_Model) as Searches from Search_log group by Laptop_Model order by count(Laptop_Model) desc;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectUsers()
        {
            string query = "select ID from s_user";
            return dbMan.ExecuteReader(query);
        }

        public DataTable UserSearched(string user)
        {
            string query = $"select Laptop_Model,search_date from Search_log where UserID={user};";
            return dbMan.ExecuteReader(query);
        }

        public int addGPU(string mn, string man, string vram, string cs)
        {
            string query = $"insert into Graphics_Card values('{mn}','{man}',{vram},{cs});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int addCPU(string b, string mn)
        {
            string query = $"insert into Processor values('{b}','{mn}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addOS(string n, string man, string v)
        {
            string query = $"insert into Operating_System values('{n}','{man}','{v}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectEdits()
        {
            string query = "select Laptop_Model,K_Type,K_Light,P_Brand,P_ModelNum,R_Size,R_DDR,g.Model_Number AS gpu_modelnum,g.Manufacturer,Vram,Clock_Speed,OS_Name,os.Manufacturer,Version,S_Manufacturer,S_Size,SC_Type,SC_Resolution,SC_Size from Composed_Of,Graphics_Card G,Processor p,Operating_System os where GPU_Model_Number=g.Model_Number and P_ModelNum=p.ModelNum and OS_Name=os.Name and OS_Ver=os.Version;";
            return dbMan.ExecuteReader(query);
        }

        public int EditLaps(string lm, string kt, string kl, string pb, string pmn,string rs,string rddr, string gpumn ,string gpuman, string vram, string cs,string osn, string osman, string osv, string sman,string ssize,string sct,string scr,string scs)
        {
            string query = $"Exec Edit @LM ='{lm}',@KT= '{kt}',@KL= '{kl}',@PB= '{pb}',@PMN='{pmn}' ,@RS= '{rs}',@RDDR = '{rddr}' ,@GPUMN= '{gpumn}',@GPUMAN ='{gpuman}',@VRAM= '{vram}',@CS ='{cs}',@OSN ='{osn}',@OSMAN ='{osman}',@OSV ='{osv}',@SMAN ='{sman}',@SSIZE ='{ssize}',@SCT ='{sct}',@SCR ='{scr}',@SCS ='{scs}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveLaptop(string lm)
        {
            string query = $"exec RemoveLaptop @LM='{lm}';";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
