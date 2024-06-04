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
                    Console.WriteLine("3.DELETE");
                    Console.WriteLine("4.SEARCH");
                    Console.WriteLine("5.SELECT");
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
                        case 4:
                            Search();
                            break;
                        case 5:
                            Showall();
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
        public void Search()
        {
            try
            {
                Console.Write("Enter Your Name:");
                var name = Console.ReadLine();
                var result = Repost. Hospitalsearch(name);
                if(result.Any())
                {
                    foreach (var s in result)
                    {
                        Console.WriteLine($" {s.Id},{s.Name}, {s.Email}, {s.Phonenumber}, {s.Pincode}"  );
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Name:"+" "+refer);
                }
                

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Showall()
        {
            try
            {
                var value = Repost.Hospitalshow();
                if (value == null || value.Count() == 0)
                {
                    Console.WriteLine("Records Not Found");
                }
                Console.WriteLine($"||Id||Name||Email||Address||PhoneNumber||Pincode||");
                foreach (var s in value)
                {
                    Console.WriteLine($"||{s.Id}||{s.Name}||{s.Email}||{s.Address}||{s.Phonenumber}||{s.Pincode}||");

                }
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}
