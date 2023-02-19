using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.UI;
using HMS.BL;
using HMS.DL;

namespace HMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "credentials.txt";
            string Admin = "Admin.txt";
            string discount = "Discount.txt";
            string Managers = "Manager.txt";
            string customer = "customer.txt";
            DiscountDL.readData(discount);
            ManagerDL.readData(Managers);
            CustomerDL.readData(customer);
            AdminDL.readData(Admin);
            MuserDL.readData(path);
            string role = "";
            char op;
            op = MuserUI.LoginPage();
            if (op == '1')
            {
                role = MuserUI.signin();
                if (role == "Admin" || role == "admin")
                {
                    HeaderUI.header();
                    while (true)
                    {
                        char option = AdminUI.Adminmenu();
                        if (option == '1')
                        {
                            Admin data = AdminUI.usersinformation();
                            AdminDL.storeData(Admin, data);
                        }
                        else if (option == '2')
                        {
                            AdminUI.view();
                            Console.ReadKey();

                        }
                        else if (option == '3')
                        {
                            AdminUI.view();
                            AdminDL.removeruser();
                        }
                        else if (option == '4')
                        {
                            char opt;
                            opt = AdminUI.managehotel();
                            if (opt < '4')
                            {

                                if (opt == '1')
                                {
                                    string id = AdminUI.takeID();
                                    string pass = AdminUI.takeinput(id);
                                    AdminDL.changepassowrd(id, pass);
                                }
                                else if (opt == '2')
                                {
                                    string id = AdminUI.takeID();
                                    int sal = AdminUI.takeSalary();
                                    AdminDL.changesalary(id, sal);

                                }
                                else if (opt == '3')
                                {
                                    //discounts..............
                                }
                                else if (opt == '4')
                                {
                                    AdminUI.Adminmenu();
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (option == '5')
                        {
                            break;
                        }
                    }
                }

                else if (role == "Manager" || role == "manager")
                {
                    while (true)
                    {

                        int option = ManagerUI.managermenu();


                        if (option == 1)
                        {
                            int value = ManagerUI.head();
                            if (value == 1)
                            {
                                ManagerUI.view();
                                Console.ReadKey();
                            }
                            else if (value == 2)
                            {
                                Admin data = AdminUI.usersinformation();
                                // AdminDL.storeData(Admin, data);

                            }
                            else
                            {
                                break;
                            }

                        }
                        else if (option == 2)
                        {
                            while (true)
                            {
                                int value = 0;

                                value = ManagerUI.roomemnu();
                                if (value == 1)
                                {
                                    Manager mans = ManagerUI.takeinput();
                                    ManagerDL.storeData(Managers, mans);
                                }
                                else if (value == 2)
                                {
                                    ManagerUI.viewRoomRecords();
                                    Console.ReadKey();
                                }
                                else if (value == 3)
                                {
                                    HeaderUI.header2("REMOVING RECORDS");
                                    ManagerUI.viewRoomRecords();
                                    ManagerDL.removeruser();
                                    Console.ReadKey();

                                }
                                else if (value == 4)
                                {
                                    string status = DiscountUI.takeroomstatus();
                                    float disc = DiscountUI.takediscount();
                                    DiscountDL.addingdiscount(disc, status, discount);
                                }
                                else if (value == 5)
                                {
                                    DiscountUI.discountdetails();
                                    Console.ReadKey();
                                }
                                else if (value == 6)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }


                else if (role == "Customer" || role == "customer")
                {

                    while (true)
                    {
                        int cust = CustomerUI.customermenu();
                        if (cust == 1)
                        {

                            Customer c = CustomerUI.makereservation();
                            CustomerDL.storeData(customer, c);
                            Console.WriteLine("\t\tData entered successfully");
                        }
                        else if (cust == 2)
                        {
                            CustomerDL.removeruser();

                        }
                        else if (cust == 3)
                        {
                            string name = CustomerUI.printbill();
                            CustomerDL.removecustomer(name);
                        }
                        else if (cust == 4)
                        {
                            CustomerUI.discountdetails();
                            Console.ReadLine();
                        }
                        else if (cust == 5)
                        {

                        }
                        else if (cust == 6)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
