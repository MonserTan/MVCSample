using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSample.DataAccessLayer;

namespace MVCSample.Models
{
    [Authorize]
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDB salesDal = new SalesERPDB();
            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDB salesDal = new SalesERPDB();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
        public UserStatus GetUserValidity(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if (u.UserName == "Sukesh" && u.Password == "Sukesh")
            {
                return UserStatus.AuthentucatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }
        public void UploadEmployees(List<Employee> employees)
        {
            SalesERPDB salesDal = new SalesERPDB();
            salesDal.Employees.AddRange(employees);
            salesDal.SaveChanges();
        }
        /*
        public bool IsValidUser(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */

    }
}