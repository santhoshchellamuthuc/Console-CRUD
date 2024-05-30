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
        public void HospitalEdit(HospitalDetails value)
        {
            try
            {
                var update = $"exec HospitalEdit'{value.Name}','{value.Address}', {value.Phonenumber}";
                refer.Open();
                refer.Execute(update);
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
        public void HospitalRemove(HospitalDetails value)
        {
            try
            {
                var remove = $"exec HospitalDelete {value.Id}";
                refer.Open();
                refer.Execute(remove);
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
    

