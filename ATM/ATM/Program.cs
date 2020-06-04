using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {


            User[] users = new User[5];
            users[0] = new User("Name1", "Surname1", new Card("123456789012", "1234", "123", "01/23", 1000));
            users[1] = new User("Name2", "Surname2", new Card("234567890123", "2345", "234", "02/24", 1100));
            users[2] = new User("Name3", "Surname3", new Card("345678901234", "3456", "345", "03/25", 1200));
            users[3] = new User("Name4", "Surname4", new Card("456789012345", "4567", "456", "04/26", 1300));
            users[4] = new User("Name5", "Surname5", new Card("567890123456", "5678", "567", "05/27", 1400));


            Start(users);


        }

        static void Start(User[] users)
        {
            Console.WriteLine("Pin daxil edin");

            string pin = Console.ReadLine();

            CheckPin(pin, users);
        }

        static void CheckPin(string pin, User[] users)
        {
            bool checkpin = true;
            string name = null;
            string surname = null;
            decimal? balance = null;
            foreach (var element in users)
            {
                if (pin == element.CreditCard.PIN)
                {
                    checkpin = true;
                    name = element.Name;
                    surname = element.Surname;
                    balance = element.CreditCard.Balance;
                    break;
                }

                else
                {
                    checkpin = false;
                    continue;
                }
            }

            if (checkpin)
            {
                Console.WriteLine($" {name} {surname} Xosh gelmisiniz ! \n \n Zehmet olmasa asagidakilardan birini secerdiniz:");
                ChooseOperation(balance);
            }

            else
            {
                Console.WriteLine("Daxil etdiyiniz PIN koda aid kart tapilmadi");
                Start(users);
            }
        }


        static void ChooseOperation(decimal? balance)
        {
            Console.WriteLine("\n 1.Balans \n 2.Nagd pul");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Balans : {balance}  AZN");
                    break;
                case 2:
                    Console.WriteLine("1. 10 AZN");
                    Console.WriteLine("2. 20 AZN");
                    Console.WriteLine("3. 50 AZN");
                    Console.WriteLine("4. 100 AZN");
                    Console.WriteLine("5. Diger Mebleg");
                    GetMoney(balance);
                    break;
                default:
                    Console.WriteLine("Duzgun emelliyati secin:");
                    ChooseOperation(balance);
                    break;
            }
        }

        static void GetMoney(decimal? balance)
        {
            Int32.TryParse(Console.ReadLine(), out int money);
            switch (money)
            {
                case 1:
                    CheckBalance(balance, 10);
                    break;
                case 2:
                    CheckBalance(balance, 20);
                    break;
                case 3:
                    CheckBalance(balance, 50);
                    break;
                case 4:
                    CheckBalance(balance, 100);
                    break;
                case 5:
                    Console.WriteLine("Meblegi daxil edin:");
                    Int32.TryParse(Console.ReadLine(), out int mny);
                    CheckBalance(balance, mny);
                    break;
                default:
                    Console.WriteLine("Duzgun emelliyati secin:");
                    GetMoney(balance);
                    break;

            }
        }

        static void CheckBalance(decimal? balance , int amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine($"  Balansinizdan {amount} AZN cixildi. \n   Balans:{balance} AZN");
                ChooseOperation(balance);
            }

            else
            {
                Console.WriteLine("Balansda yeterli qeder mebleg yoxdur");
                ChooseOperation(balance);
            }
        }
    }


    class Card
    {
        public Card(string pan, string pin, string cvc, string expireDate, decimal balance)
        {
            PIN = pin;
            PAN = pan;
            CVC = cvc;
            ExpireDate = expireDate;
            Balance = balance;
        }

        public string PIN { get; set; }
        public string PAN { get; set; }
        public string CVC { get; set; }
        public string ExpireDate { get; set; }

        public decimal Balance { get; set; }


    }

    class User
    {
        public User(string name, string surname, Card creditCard)
        {
            Name = name;
            Surname = surname;
            CreditCard = creditCard;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard { get; set; }


    }
}
