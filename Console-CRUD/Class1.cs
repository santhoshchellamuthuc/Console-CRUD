/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CRUD
{
    class Class1
    {using SanthoshLibrary;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santcon
    {
        class RegsValueConsume
        {
            int obtion;
            RegistrsationRepostry value;
            public RegsValueConsume()
            {
                value = new RegistrsationRepostry();

            }
            public void RegsiterMenu()
            {

                do
                {
                    Console.WriteLine("Obtion Select");
                    Console.WriteLine("1.Insert");
                    Console.WriteLine("2.update");
                    Console.WriteLine("3.Delete");
                    Console.WriteLine("4.showall");
                    Console.WriteLine("5.searchall");
                    Console.WriteLine("6.StoreprocedureInsert");
                    Console.WriteLine("7.StoreprocedureUPdate");
                    Console.WriteLine("8.storeprocedureDelete");
                    Console.WriteLine("9.storeprocedureShowAll");
                    Console.WriteLine("10.storeprocedureSearchall");
                    Console.WriteLine("11.Exit");

                    Console.Write("Any One Obtion Select:");
                    obtion = Convert.ToInt32(Console.ReadLine());


                    switch (obtion)
                    {
                        case 1:
                            userinput();

                            break;
                        case 2:
                            UpdateData();
                            break;
                        case 3:
                            Deletedata();
                            break;
                        case 4:
                            SelectData();
                            break;
                        case 5:
                            SearchData();
                            break;
                        case 6:
                            spuseuserinput();
                            break;
                        case 7:
                            spupdateData();
                            break;
                        case 8:
                            spdeletedata();
                            break;
                        case 9:
                            spselectalldata();
                            break;
                        case 10:
                            spsearchdata();
                            break;

                    }


                } while (obtion != 11);



            }
            public void userinput()
            {
                try
                {
                    Registrasation obj = new Registrasation();
                    Console.WriteLine("Enter The username:");
                    obj.UserName = Console.ReadLine();
                    Console.WriteLine("Enter The UserId:");
                    obj.UserId = Console.ReadLine();
                    Console.WriteLine("Enter The Email:");
                    obj.Email = Console.ReadLine();
                    Console.WriteLine("Enter The PhoneNumber:");
                    obj.PhoneNumber = Convert.ToInt64(Console.ReadLine());


                    value.Signup(obj);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public void UpdateData()
            {
                try
                {
                    Console.Write("Enter The NewUserName :");
                    var UserName = Console.ReadLine();
                    Console.Write("Enter the NewPhoneNumber :");
                    var PhoneNumber = Convert.ToInt64(Console.ReadLine());

                    value.Update(PhoneNumber, UserName);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public void Deletedata()
            {
                try
                {
                    Console.WriteLine("Enter The UserName:");
                    var NewUserName = Console.ReadLine();
                    value.Delete(NewUserName);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            RegistrsationRepostry select = new RegistrsationRepostry();
            public void SelectData()
            {
                try
                {
                    var Register = select.Selectall();
                    if (Register == null || Register.Count() == 0)
                    {
                        Console.WriteLine("There Is No Records");
                    }
                    Console.WriteLine($"|| UserName          ||  UserId         ||   Email                 ||   PhoneNumber     ||");

                    foreach (var d in Register)
                    {
                        Console.WriteLine($"|| {d.UserName}      ||  {d.UserId}     ||   {d.Email}             ||   {d.PhoneNumber} ||");
                    }
                    return;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            RegistrsationRepostry search = new RegistrsationRepostry();

            public void SearchData()
            {
                try
                {
                    Console.Write("Enter The Word:");
                    var name = Console.ReadLine();
                    var searching = search.Searchall(name);
                    if (searching.Any())
                    {
                        foreach (var ss in searching)
                        {
                            Console.WriteLine("UserName:" + "      " + ss.UserName);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid UserName" + "  " + name);
                    }


                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// ///////////////////////////////////////////storeprocedure/////////////////////////////////////////////////////////////////////////////////////////
            /// </summary>
            public void spuseuserinput()
            {
                try
                {
                    Registrasation store = new Registrasation();
                    Console.WriteLine("Enter The username:");
                    store.UserName = Console.ReadLine();
                    Console.WriteLine("Enter The UserId:");
                    store.UserId = Console.ReadLine();
                    Console.WriteLine("Enter The Email:");
                    store.Email = Console.ReadLine();
                    Console.WriteLine("Enter The PhoneNumber:");
                    store.PhoneNumber = Convert.ToInt64(Console.ReadLine());


                    value.storeprocedureSignup(store);
                }
                catch (Exception)
                {
                    throw;

                }
            }

            public void spupdateData()
            {
                try
                {
                    Console.Write("Enter The NewPhoneNumber:");
                    var NewPhoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter The ConfirmPhoneNumber:");
                    var ConfirmPhoneNumber = Convert.ToInt64(Console.ReadLine());


                    if (NewPhoneNumber == ConfirmPhoneNumber)
                    {
                        Console.Write("Enter The UserName:");
                        var UserName = Console.ReadLine();
                        var resultUserName = value.SPvaildate(UserName);

                        if (resultUserName.Any())
                        {
                            value.SPupdate(UserName, NewPhoneNumber);
                            Console.WriteLine("Successfully PhoneNumber UPdated ");

                        }
                        else
                        {
                            Console.WriteLine("Somthing Has Wrong");

                        }
                    }
                }
                catch (Exception)
                {
                    throw;

                }
            }
            public void spdeletedata()
            {
                try
                {
                    Console.Write("Enter The UserName:");
                    var username = Console.ReadLine();
                    var resultusername = value.SPvaildate(username);
                    if (resultusername.Any())
                    {
                        value.SPdelete(username);
                        Console.WriteLine("Successfully Records deleted");

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
            RegistrsationRepostry spshow = new RegistrsationRepostry();
            /// ///////SP ShowAll/////////////////
            /// </summary>
            public void spselectalldata()
            {
                try
                {
                    var storedata = spshow.SPselectall();
                    if (storedata == null || storedata.Count() == 0)
                    {
                        Console.WriteLine("No Records Found");
                    }
                    Console.WriteLine($"    ||    UserName          ||  UserId          ||   Email                      ||   PhoneNumber     ||");
                    foreach (var san in storedata)
                    {
                        Console.WriteLine($"||   {san.UserName}     || {san.UserId}     ||  {san.Email}                 ||  {san.PhoneNumber}||");
                    }
                    return;
                }
                catch (Exception)

                {
                    throw;
                }
            }
            RegistrsationRepostry searchall = new RegistrsationRepostry();
            public void spsearchdata()
            {
                try
                {
                    Console.Write("Enter The String:");
                    var Name = Console.ReadLine();
                    Registrasation entity = new Registrasation();
                    var result = searchall.SPsearchall(Name);
                    if (result.Any())
                    {
                        foreach (var san in result)
                        {
                            Console.Write($"  " + "     " + san.UserName, san.Email);
                        }
                    }
                    else
                    {
                        Console.Write($"Somthing Went To Wrong:" + "    " + Name);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }

}
}
*/