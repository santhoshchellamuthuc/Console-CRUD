using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLibrary;

namespace Console_CRUD
{
    public  class HospitalRecordsConsume
    {
        int Option;
        HospitalRepostery Repost;
        HospitalDetails refer;

        public HospitalRecordsConsume()
        {
            Repost = new HospitalRepostery();
            refer = new HospitalDetails();
        }
        public void HospitalList()
        {
            try
            {
                do
                {
                    Console.WriteLine("1.CREATE");
                    Console.WriteLine("2.Edit");
                    Console.WriteLine("3.SELECT");
                    Console.WriteLine("4.SEARCH");
                    Console.WriteLine("5.DELETE");
                    Console.WriteLine("Enter Any One Option Select:");
                    Option = Convert.ToInt32(Console.ReadLine());

                    switch (Option)
                    {
                        case 1:
                            Insert();
                            break;
                        case 2:
                            Edit();
                            break;
                        case 3:
                            Remove();
                            break;


                    }

                } while (Option != 5);
               

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert()
        {
            try
            {
                Console.Write("Enter Your Name:");
                refer.Name = Console.ReadLine();
                Console.Write("Enter Your Email:");
                refer.Email = Console.ReadLine();
                Console.Write("Enter Your Address:");
                refer.Address = Console.ReadLine();
                Console.Write("Enter Your PoneNumber:");
                refer.Phonenumber = Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter Your Pincode:");
                refer.Pincode = Convert.ToInt64(Console.ReadLine());

                Repost.HospitalLogin(refer);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Edit()
        {
            try
            {
                Console.Write("Enter Your Name:");
                refer.Name = Console.ReadLine();
                Console.Write("Enter Your NewAddress:");
                refer.Address = Console.ReadLine();
                Console.Write("Enter Your NewPhoneNumber:");
                refer.Phonenumber = Convert.ToInt64(Console.ReadLine());

                Repost.HospitalEdit(refer);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove()
        {
            try
            {
                Console.Write("Enter Your Id:");
                refer.Id = Convert.ToInt64(Console.ReadLine());
                Repost.HospitalRemove(refer);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<HospitalDetails>Search()
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}
