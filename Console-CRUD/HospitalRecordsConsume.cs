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
        public HospitalRecordsConsume()
        {
            Repost = new HospitalRepostery();
        }
        public void HospitalList()
        {
            try
            {
                do
                {
                    Console.WriteLine("1.CREATE");
                    Console.WriteLine("2.UPDATE");
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
                HospitalDetails refer = new HospitalDetails();
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
                Console.Write("Enter The NewPhoneNumber:");
                var Newemail = Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter The ConfirmPhoneNumber:");
                var Confirmemail = Convert.ToInt64(Console.ReadLine());


                if (Newemail == Confirmemail)
                {
                    Console.Write("Enter The UserName:");
                    var Id  = Console.ReadLine();
                    var result= Repost.SPvaildate(Id);

                    if (result.Any())
                    {
                        Repost.HospitalEdit(Id, NewP);
                        Console.WriteLine("Successfully PhoneNumber UPdated ");

                    }
                    else
                    {
                        Console.WriteLine("Somthing Has Wrong");

                    }
                }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}
