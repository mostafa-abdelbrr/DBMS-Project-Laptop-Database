﻿using System;
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
    }
}
