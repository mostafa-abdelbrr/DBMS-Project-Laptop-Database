using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
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
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNum()
        {
            string query= "SELECT Dnumber, Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepartment()
        {
            string query = "SELECT DISTINCT Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }

        //TODO:
        //Get SSN and address for all employees with salary less than 40000.
        public DataTable SelectAllEmployeesWithSalaryLessThan(string salary)
        {
            string query = "select SSN, Address from Employee where Salary < '" + salary + "';";
            return dbMan.ExecuteReader(query);
        }

        //Make Sure to show only SSN and Address Not all columns

        //TODO:
        //Get all female employees who work in "Administration" department
        public DataTable SelectEmployeesinDeptBySex(string sex, string dept)
        {
            string query = "select e.name,e.ssn from Employee e, Department where Sex = '"+ sex +"' and Dno = Department.Dnumber and Department.Dname = '"+ dept +"';";
            return dbMan.ExecuteReader(query);
        }
        //FunctionName "returnType" GetAllGenderWorkingInDepartment(?,?)
        //Make sure to get their Names and maybe SSN only

        //TODO:
        //Get departments names for all departments located at "Houston" (1 mark)
        //FunctionName: "returnType" GetDepartmentNamesAtLocation(?)
        //Just Get the Names
        public DataTable GetDepartmentNamesAtLocation(string deptloc)
        {
            string query = "select Dname from Department d, Dept_Locations dl where d.Dnumber=dl.Dnumber and dl.Dlocation='" + deptloc + "';";
            return dbMan.ExecuteReader(query);
        }


        //TODO:
        //Insert a new department. (1 mark)
        //Make sure all the required fields are given and if any important Field missing, give the user appropriate message
        public DataTable InsertDept(string dept, string dno, string mgrssn, string mgrstart)
        {
            string query = "insert into Department values('" + dept + "', '" + dno + "', '" + mgrssn + "', '" + mgrstart + "'); ";
            return dbMan.ExecuteReader(query);
        }



        //(To be delivered next lab)
        //
        //TODO:
        //5-Get employees names and salaries for all employees 
        //who work in a project located at "Stafford" or in "Houston" 
        //and work less than 35 hours. (1 marks)
        public DataTable GetEmployeesWithLessHours(string hours,string deptloc1, string deptloc2)
        {
            string query = "select distinct e.Fname,e.Minit,e.Lname, e.salary from Employee e, Works_On w, Project p where e.SSN = w.Essn and w.Pno = p.Pnumber and w.Hours < '" + hours + "' and p.Plocation in ('" + deptloc1 + "','" + deptloc2 + "'); ";
            return dbMan.ExecuteReader(query);
        }

        //6- Allow user to update salary of an employee of a certain SSN. (1 mark)
        public DataTable EditSalarybySSN(string salary, string ssn)
        {
            string query = "update Employee set salary = '"+salary+"' where SSN = '"+ssn+"';";
            return dbMan.ExecuteReader(query);
        }
        //7-Get the last names of department managers and their salaries. (1 mark)
        public DataTable GetLnameofManagers()
        {
            string query = "select distinct e.Lname from Employee e,Department d where e.SSN = d.Mgr_SSN;";
            return dbMan.ExecuteReader(query);
        }
        //8-Get Name and SSN for all employees working in "Research" department or working on projects controlled by "Research" department. (2 marks)
        public DataTable GetNSworkinginorcontrolledby(string dept)
        {
            string query = "select distinct e.Fname, e.Minit, e.Lname, e.SSN from Employee e, Department d, Works_On w, Project p where ((e.Dno=d.Dnumber) or (w.Pno=p.Pnumber and p.Dnum=d.Dnumber and e.SSN=w.Essn)) and d.Dname = '" + dept + "';";
            return dbMan.ExecuteReader(query);
        }
        //9-Get maximum, minimum and average salary for employees(1 mark)
        public DataTable GetMaxMinAvg()
        {
            string query = "Select Max(e.Salary), Min(e.Salary), Avg(e.Salary) from Employee e";
            return dbMan.ExecuteReader(query);
        }


    }
}
