using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bank_application_software
{

    public class loginInfo
    {
        public void loginpage()
        {
            string username;
            string password;
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("                                        *******    Login Page     **********");
            Console.WriteLine("**********************************************************************************************************************");       
            Console.Write("                          user-name:--");
            username = Console.ReadLine();
            Console.Write("                          password:---");
            password = Console.ReadLine();

            if (username == "kalyani")
            {
                if (password == "1234")
                {

                    Console.WriteLine(" ");
                    Console.WriteLine("                            ***********LOGIN SUCESS!!!!!***********");
                }
                Console.WriteLine(" ");
                //try
                //{

                //    if (password == " ")
                //    {
                //        throw Exception e;
                //    }
                //}
                //catch(Exception e)
                //{
                //    Console.WriteLine(e);
                //}
                //finally
                //{
                //    Console.WriteLine("!!!!!@@@@@!!!!!");
                //}
            }
            else
            {
                Console.WriteLine("enter details correctly");
            }

        }
    }

    public class customerdetails
    {
        public void atmInfo()
        {
            Console.WriteLine("\t \t \t \t     \tDo u want to add ATM services");
            Console.WriteLine("===================================********************************================================");
            Console.WriteLine("click on 1-->to choose atm services");
            Console.WriteLine("click on 0-->to exit");

            int a = Convert.ToInt32(Console.ReadLine());
            int amount, deposit, withdraw;
            int choice, x = 0;

            Console.WriteLine("initiallu account is NULL please how much amount do u want to deposit:-");
            amount = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("WELCOME TO  BANK ATM SERVICE\n");

                    while (true)
                    {
                    int num;

                    for (num = 1; num <= 3; num++)
                    {

                        //Console.WriteLine("0.list of records\n");
                        Console.WriteLine("1. Current Balance\n");
                        Console.WriteLine("2. Withdraw \n");
                        Console.WriteLine("3. Deposit \n");
                        Console.WriteLine("4. EXIT \n");
                        Console.WriteLine("***************\n\n");
                        Console.WriteLine("ENTER YOUR CHOICE : ");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {

                            case 1:
                                // Console.WriteLine("ur account balance is:-");
                                //amount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                                break;
                            case 2:

                                Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                                withdraw = int.Parse(Console.ReadLine());
                                if (withdraw % 100 != 0)
                                {
                                    Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                                }
                                else if (withdraw > (amount - 1000))
                                {
                                    Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                                }
                                else
                                {
                                    amount = amount - withdraw;
                                    Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");

                                    Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                                }

                                //while(i>3)
                                //{
                                //    amount = amount - 500;
                                //    Console.WriteLine("the amount is" + amount);
                                //    Console.WriteLine("u have used the more than three times");
                                //}
                                break;

                            case 3:
                                Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                                deposit = int.Parse(Console.ReadLine());
                                amount = amount + deposit;
                                Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                                Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                                break;
                            case 4:
                                Console.WriteLine("\n THANK YOU…");
                                Environment.Exit(0);
                                break;

                        }
                       
                    }
                    if (num > 3)
                    {
                        Console.WriteLine("u have used more than three times");
                        amount = amount - 500;
                        Console.WriteLine("balance is" + amount);
                        Console.WriteLine("\n\n THANKS FOR USING  ATM SERVICE");
                        break;
                    }
                } 
               
            }
            else if(a==0)
            {
                
                
              Console.WriteLine("\n\n THANKS FOR USING  ATM SERVICE");
                Environment.Exit(0);
            }

        }


        public void selectOption()

        {

            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("             ---------8BANKING software APPLICATION--------");
            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("Check the list of available options:-");
            Console.WriteLine();
            Console.WriteLine("1.saving account:--");
            Console.WriteLine("2.current account:--");
            Console.WriteLine("3.child care account:--");
            Console.WriteLine("++++++++++++++++++++++====================+++++++++++++++++++=============");
            Console.WriteLine();
            Console.WriteLine("please enter your choice");


            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("you have choosed the SAVING ACCOUNT");
                    Console.WriteLine("++++++++++++++++++++++============Thankyou for choosing SAVING ACCOUNT========+++++++++++++++++++============");                  
                    Console.WriteLine("for saving account your daily limit is only 100000 INR");
                       break;
                case 2:
                    Console.WriteLine("you have choosed the CURRENT ACCOUNT");                 
                    Console.WriteLine("++++++++++++++++++++++=======Thankyou for choosing CURRENT ACCOUNT=============+++++++++++++++++++============");
                   Console.WriteLine("for saving account your daily limit is only 200000 INR");              
                    break;
                case 3:
                    Console.WriteLine("you have choosed the CHILD CARE ACCOUNT");
                    Console.WriteLine("++++++++++++++++++++++=========Thankyou for choosing CHILD CARE ACCOUNT===========+++++++++++++++++++==========");
                      Console.WriteLine("for saving account your daily limit is only 50000 INR");
                      break;
                default:
                    Console.WriteLine("u have entered is invalid choice");

                    break;


            }

            Console.WriteLine("Thank You");
        }
    }

    public class custInfo
    {
        public void info()
        {
            string nameOfAccountHolder;
            int age;
            int dobYear;
            string address;
            int mobilenum;
            Console.Write("enter your name:-");
            nameOfAccountHolder = Console.ReadLine();
            Console.Write("enter your age:--");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter your dob year:--");
            dobYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter your address:-");
            address = Console.ReadLine();
            Console.Write("enter your mobile number:--");
            mobilenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++============account created successfully!!!Thank you=================+++++++++++++++++++=");
            Console.WriteLine("please check your information:-");
            Console.WriteLine("name:---" + nameOfAccountHolder);
            Console.WriteLine("age:----" + age);
            Console.WriteLine("dob year:---" + dobYear);
            Console.WriteLine("mobile num:----" + mobilenum);


        }



        public void infoOfCustomer()
        {
            int opt;
            
                Console.WriteLine("enter your choice");
                Console.WriteLine("1.you want to create a account");
                Console.WriteLine("2.List of records");
                Console.WriteLine("3.Exit");
           
                opt = Convert.ToInt32(Console.ReadLine());

            //switch (opt)
            //{
            //    case 1:
            //        custInfo c = new custInfo();
            //        c.info();
            //        break;
            //    case 2:
            //        customer c1 = new customer();
            //        c1.custDetails();
            //        Console.WriteLine("Thank you for visit us");
            //        break;
            //    case 3:
            //    //while (opt == 3)
            //    //{
            //    //    Console.WriteLine("thank you");
            //        break;
            //default:
            //    Console.WriteLine("thank you");



                //}

            if (opt == 1)
            {
                Console.WriteLine("Enter the details to proceed:-");
                custInfo c = new custInfo();
                c.info();

            }
          

            else if (opt == 2)
            {
                customer c1 = new customer();
                c1.custDetails();
                Console.WriteLine("Thank you for visit us");
                

            }

           else
            {
                Environment.Exit(0);

            }

        }
    }
    public class customer 
    {
        public int age
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string accounttype
        {
            get;
            set;
        }
        public int balance
        {
            get;
            set;
        }
        public void custDetails()
        {


            customer emp = new customer()
            {
                age = 21,
                name = "amit",
                accounttype = "saving",
                balance = 87000

            };
            customer emp1 = new customer()
            {
                age = 12,
                name = "syam",
                accounttype = "current",
                balance = 24000

            };
            customer emp2 = new customer()
            {
                age = 21,
                name = "smit",
                accounttype = "saving",
                balance = 34000

            };
            customer emp3 = new customer()
            {
                age = 22,
                name = "ramu",
                accounttype = "current",
                balance = 28000

            };
            List<customer> em = new List<customer>();
            em.Add(emp);
            em.Add(emp1);
            em.Add(emp2);
            em.Add(emp3);



            Console.WriteLine("List of bank customer data ");
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("name                           "+"age                     "+"accounttype                    " +"blance");
            string path = "C:\\customer";
            StreamWriter sw = new StreamWriter(path);
            foreach(customer c in em)
            {
                sw.WriteLine(c.accounttype + "\t");

                sw.WriteLine(c.age + "\t");

                sw.WriteLine(c.name + "\t");

            }
            sw.Close();
            Console.WriteLine("****************************************************************************************************************");
            foreach (customer c in em)
            {   
                Console.WriteLine(c.name + "           ||                " + c.age + "              ||                   " + c.accounttype+"      ||            "+c.balance);
                
            }
            Console.WriteLine("****************************************************************************************************************");

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("age={0} ||  name={1} || accounttype={2}, || balance={3}", emp.age, emp.name, emp.accounttype, emp.balance);
            //Console.WriteLine("age={0} ||  name={1} || accounttype={2}, || balance={3}", emp1.age, emp1.name, emp1.accounttype, emp1.balance);
            //Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {

            customer cus = new customer();
            loginInfo l = new loginInfo();
            l.loginpage();
            //cus.custDetails();
            customerdetails c = new customerdetails();
            custInfo c2 = new custInfo();
           // customer cus = new customer();


            c.selectOption();
            c2.infoOfCustomer();
            c2.info();
            
           // cus.custDetails();

            c.atmInfo();
            Console.ReadKey();

        }

    }
}
