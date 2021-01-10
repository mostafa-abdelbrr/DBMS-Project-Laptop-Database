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
        public int promote(string model)
        {
            string query = "UPDATE Laptop Set Promoted = 'WAITING' where Model = '" + model + "' ";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable fillPromoBox(string store)
        {
            string query = "select Laptop_Model from Bought_From where Store_Name = '" + store + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillPromoTable()
        {
            string query = "select * From Laptop where  Promoted = 'WAITING' ";
            return dbMan.ExecuteReader(query);
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
         int addToScreen(string type, string res, string size, string model)
        {
            string query = "INSERT INTO Screen Values ('" + type + "','" + res + "','" + size + "','" + model + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillosManu()
        {
            string query = "SELECT DISTINCT Manufacturer From Operating_System";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillosName(string manu)
        {
            string query = "SELECT Distinct Name From Operating_System WHERE Manufacturer = '" + manu + "' ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillosVer(string os)
        {
            string query = "SELECT  Version From Operating_System WHERE Name = '" + os + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillDashStore(string store)
        {
            string query = "select Name, Composed_Of.Laptop_Model as 'Model',K_type as 'Keyboard',K_Light as 'Light On Keyboard',P_brand as 'Processor',p_ModelNum as 'Processor Model Number',R_size as 'Ram' ,R_DDR as 'DDR',GPU_Model_Number as 'GPU',OS_Manufacturer as 'Operating system Vendor',OS_Name as 'Operating System',OS_Ver as 'Operating System Version',HDD_Manufacturer as 'HDD Manufacturer',HDD_Size as 'HDD Size',SSD_Manufacturer as 'SSD Manufacturer',SSD_Size as 'SSD Size',USB2 as 'No. Of USB2 Ports',USB3 as 'No. Of USB3 Ports',SC_Type as 'Screen',SC_Resolution as 'Resolution',SC_Size as 'Size' FROM Laptop, Composed_Of,Bought_From where Laptop.Model = Composed_of.Laptop_Model AND Composed_Of.Laptop_Model = Bought_From.Laptop_Model AND Bought_From.Store_Name = '"+store+"'";
            return dbMan.ExecuteReader(query);
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

         int addToRam(string ram, string ddr, string model)
        {
            string query = "INSERT INTO RAM VALUES ('" + ram + "','" + ddr + "','" + model + "')";
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
         int addToLaptop(string modelNum, string name, string date)
        {

            string query = "INSERT INTO Laptop Values('" + modelNum + "','" + name + "','" + date + "',0,0)";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillManufacturerComboBox()
        {
            string query = "Select Name From Manufacturer_Data";
            return dbMan.ExecuteReader(query);
        }

         int addToManufacturer(string maker, string model, string date)
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

        public DataTable checkGPU(string brand, string model)
        {
            string query = "SELECT Manufacturer,Model_Number FROM Graphics_Card Where Manufacturer = '" + brand + "' AND Model_Number = '" + model + "'";
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


         int addToBoughtFrom(string model, string store, string price, string stock)
        {
            string query = "INSERT INTO Bought_From VALUES('" + model + "','" + store + "','" + price + "','" + stock + "')";
            return dbMan.ExecuteNonQuery(query);
        }

         int addToKeyBoard(string type, string light, string lapModel)
        {
            string query = "INSERT INTO KeyBoard VALUES('" + type + "','" + light + "','" + lapModel + "')";
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

         int addToStorage(string hddM, string ssdM, string hdd, string ssd, string lapModel)
        {
            string query = "insert into Storage VALUES ('" + hddM + "','" + ssdM + "','" + hdd + "','" + ssd + "','" + lapModel + "')";
            return dbMan.ExecuteNonQuery(query);
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

         int addToUSB(string lapModel, string usb2, string usb3)
        {
            string query = "INSERT INTO USB_Type VALUES ('" + lapModel + "', '" + usb2 + "','" + usb3 + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getall()
        {
            string query = "Select * from Laptop"; // TODO: Add a select all feature
            return dbMan.ExecuteReader(query);
        }

         int addToComposedOf(string model, string procMaker, string procModel, string gpu, string osManu, string os, string osVer)
        {
            string query = "exec fillComposedOf '" + model + "','" + procMaker + "','" + procModel + "','" + gpu + "','" + osManu + "','" + os + "','" + osVer + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int newLaptop(string lapModel, string lapName, string date, string manu, string store, string price, string stock, string ram, string ddr, string hddM, string ssdM, string hdd, string ssd, string kbType, string kbLight, string usb2, string usb3, string screenType, string screenRes, string screenSize, string procManu, string procModel, string gpu, string osManu, string os, string osVer)
        {
            int lap = addToLaptop(lapModel, lapName, date);
            int manufacturer = addToManufacturer(manu, lapModel, date);
            int bought = addToBoughtFrom(lapModel, store, price, stock);
            int _ram = addToRam(ram, ddr, lapModel);
            int storage = addToStorage(hddM, ssdM, hdd, ssd, lapModel);
            int kb = addToKeyBoard(kbType, kbLight, lapModel);
            int usb = addToUSB(lapModel, usb2, usb3);
            int screen = addToScreen(screenType, screenRes, screenSize, lapModel);

            int comp = addToComposedOf(lapModel, procManu, procModel, gpu, osManu, os, osVer);

            if (lap + manufacturer + bought + _ram + storage + kb + usb + screen + comp != 9)
            {
                return -1;
            }

            return 0;
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
            string query = "select Laptop_Model,K_Type,K_Light,P_Brand,P_ModelNum,R_Size,R_DDR,g.Model_Number AS gpu_modelnum,g.Manufacturer,Vram,Clock_Speed,OS_Name,os.Manufacturer,Version,HDD_Manufacturer,SSD_Manufacturer,HDD_Size,SSD_Size,SC_Type,SC_Resolution,SC_Size,USB2,USB3 from Composed_Of,Graphics_Card G,Processor p,Operating_System os where GPU_Model_Number=g.Model_Number and P_ModelNum=p.ModelNum and OS_Name=os.Name and OS_Ver=os.Version;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEditsStore(string store)
        {
            string query = "select Composed_Of.Laptop_Model,K_Type,K_Light,P_Brand,P_ModelNum,R_Size,R_DDR,g.Model_Number AS gpu_modelnum,g.Manufacturer,Vram,Clock_Speed,OS_Name,os.Manufacturer,Version,HDD_Manufacturer,SSD_Manufacturer,HDD_Size,SSD_Size,SC_Type,SC_Resolution,SC_Size,USB2,USB3 from Bought_From, Composed_Of,Graphics_Card G,Processor p,Operating_System os where GPU_Model_Number=g.Model_Number and P_ModelNum=p.ModelNum and OS_Name=os.Name and OS_Ver=os.Version AND Bought_From.Laptop_Model = Composed_Of.Laptop_Model AND Bought_From.Store_Name = '"+store+"'";
            return dbMan.ExecuteReader(query);
        }

        public int EditLaps(string lm, string kt, string kl, string pb, string pmn, string rs, string rddr, string gpumn, string gpuman, string vram, string cs, string osn, string osman, string osv, string hddman, string ssdman, string hddsize, string ssdsize, string sct, string scr, string scs, string usb2, string usb3)
        {
            string query = $"Exec Edit @LM ='{lm}',@KT= '{kt}',@KL= '{kl}',@PB= '{pb}',@PMN='{pmn}' ,@RS= '{rs}',@RDDR = '{rddr}' ,@GPUMN= '{gpumn}',@GPUMAN ='{gpuman}',@VRAM= '{vram}',@CS ='{cs}',@OSN ='{osn}',@OSMAN ='{osman}',@OSV ='{osv}',@HDDMAN ='{hddman}',@SSDMAN='{ssdman}',@HDDSIZE='{hddsize}',@SSDSIZE='{ssdsize}',@SCT ='{sct}',@SCR ='{scr}',@SCS ='{scs}',@U2='{usb2}',@U3='{usb3}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveLaptop(string lm)
        {
            string query = $"exec RemoveLaptop @LM='{lm}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetInformation(string Name)
        {
            string query = "Select * from Laptop where Model=" + Name + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetProcessor(string Name)
        {
            string query = "Select Brand, ModelNum From Laptop l,Composed_Of c ,Processor p" +
                "Where l.Model=c.Laptop_Model AND P.ModelNum=C.P_ModelNum AND l.Model=" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetGarphicsCard(string Name)
        {
            string query = "Select Manufacturer, Vram, Clock_speed  " +
                "From Laptop l, Composed_Of c, Graphics_Card g " +
                "Where l.Model = c.Laptop_Model AND GPU_Model_Number = g.Model_Number AND l.Model = '" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetRAM(string Name)
        {
            string query = "Select Size,DDR " +
                "From Laptop l, RAM r" +
                "Where l.Model=r.Laptop_Model AND l.Model ='" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetOS(string Name)
        {
            string query = "Select o.Name, Manufacturer, o.Version " +
                "from Laptop l, Composed_Of c, Operating_System o " +
                "Where l.Model = c.Laptop_Model AND c.OS_Name = o.Name AND l.Model ='" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStorage(string Name)
        {
            string query = "Select s.Size, s.Manufacturer, s.HDD, s.SDD " +
                "From Laptop l, Storage s " +
                "where l.Model = s.Laptop_Model AND l.Model = '" + Name + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetScreen(string Name)
        {
            string query = "Select s.Type, s.Resolution, s.Size " +
                "From Laptop l, Screen s " +
                "Where l.Model = s.Laptop_Model AND l.Model = '" + Name + "'; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetManufacturer(string Name)
        {
            string query = "Select M_Name, Phone, Official_service_centre_address " +
                "From Laptop l, Manufacturered_By MB, Manufacturer_Data MD, M_Contact_Info MC" +
                "WHERE l.Model = MB.Laptop_Model AND MB.Name = MD.Name AND MD.Name = MC.M_Name AND l.Model = '" + Name + "'; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStore(string Name)
        {
            string query = "SELECT b.Price, b.InStock, s.Name, s.Address  " +
                "From Laptop l, Bought_From b, Store s " +
                "Where l.Model = b.Laptop_Model AND b.Store_Name = s.Name AND l.Model = '" + Name + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetUSB(string Name)
        {
            string query = "Select Type , Number  " +
                "From Laptop l, USB_Type u " +
                "Where L.Model = u.Laptop_Model AND l.Model = '" + Name + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetKeyboard(string Name)
        {
            string query = "Select K_Type, K_Light, Language  " +
                "From Laptop l, KeyBoard k, K_Languages kl " +
                "where l.Model = k.Laptop_Model AND k.Laptop_Model = kl.Laptop_Model AND l.Name = '" + Name + "'; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectGPUs()
        {
            string query = "select * from Graphics_card;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCPUs()
        {
            string query = "select * from processor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectOSs()
        {
            string query = "select * from Operating_System;";
            return dbMan.ExecuteReader(query);
        }

        public int EditGpu(string omn,string mn, string man, string vr, string cs)
        {
            string query = $"update Graphics_Card set Model_Number='{mn}',Manufacturer='{man}',Vram='{vr}',Clock_Speed='{cs}' where Model_Number='{omn}';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int EditCpu(string omn, string pb, string mn)
        {
            string query = $"update Processor set Brand='{pb}',ModelNum='{mn}' where ModelNum='{omn}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int EditOs(string oosn,string oosman,string oosv, string osn, string osman, string osv)
        {
            string query = $"update Operating_system set Name='{osn}',Manufacturer='{osman}',Version='{osv}' where Name='{oosn}' and Manufacturer='{oosman}' and Version='{oosv}'";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectStorOwnersTobeApproved()
        {
            string query = "select * from S_user where role='Store_WAITING_APPROVAL';";
            return dbMan.ExecuteReader(query);
        }
        public int ApproveStore(string id)
        {
            string query = "update S_User set Role='Store' where id=" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DenyStore(string id)
        {
            string query = $"Delete from S_User where ID={id};";
            return dbMan.ExecuteNonQuery(query);
        }

        public string GetRating (string Name)
        {
            string query = "Select Rating  " +
                "From Laptop l, Rating r" +
                "Where l.Model = r.Laptop_Model And l.Model = '" + Name + "'";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int Rate (string LapId, int UserId,string Rating)
        {
            string query = "INSERT INTO Rating Values ('"+LapId+"',"+UserId+","+Rating+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public string GetModel (string Name)
        {
            string query = "SELECT Model From Laptop WHERE Name= " + Name + ";";
            return (string)dbMan.ExecuteScalar(query);
        }
    }
}
