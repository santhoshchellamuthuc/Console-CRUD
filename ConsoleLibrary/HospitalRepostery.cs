using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace ConsoleLibrary
{
   public  class HospitalRepostery
    {
        string connectionstring = "Data source=DESKTOP-23V7KHU;Initial Catalog=SanthoshkumarAPI;User id=sa;password=Anaiyaan@123";
        SqlConnection refer;
        public HospitalRepostery()
        {
            refer = new SqlConnection(connectionstring);

        }
        public void HospitalLogin(HospitalDetails value)
        {
            try
            {
                var insert = $"Insert into HospitalDetails values ('{value.Name}','{value.Email}','{value.Address}',{value.Phonenumber},{value.Pincode})";
                refer.Open();
                refer.Execute(insert);
                refer.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public IEnumerable<HospitalDetails> Hospitalshow()
        {
            try
            {
                var insert = ($"select *from HospitalDetails");
                refer.Open();
                var result = refer.Query<HospitalDetails>(insert);
                refer.Close();
                return result;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<HospitalDetails> Hospitalsearch(string name)
        {
            try
            {
                var insert = $"EXEC HospitalSearch '{name}'";
                refer.Open();
                var result = refer.Query<HospitalDetails>(insert);
                refer.Close();
                return result;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void HospitalEdit(long Id, string data)
        {
            try
            {
                var refer = $"Update HospitalDetails{Id},'{data}'";
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void HospitalRemove(int id)
        {
            try
            {
                var value = $"exec HospitalDelete {id}";
                refer.Open();
                refer.Execute(value);
                refer.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
    

