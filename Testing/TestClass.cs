using _1291763.Factory_Layer;
using _1291763.Models;
using _1291763.Repository_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291763.Testing
{
    public class TestClass
    {
        IRepoFactory factory;
        public TestClass(IRepoFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            // Blue heading
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===============================================");
            Console.WriteLine("           BANK & CLIENT REPOSITORY TEST       ");
            Console.WriteLine("===============================================");
            Console.ResetColor();

            IRepo<Bank> repoB = factory.CreateRepo<Bank>();
            repoB.AddRange(new Bank[]
            {
            new Bank{Id=1, Name="NRBC Bank", Branch="Motijheel"},
            new Bank{Id=2, Name="DBBL", Branch="Gulshan"},
            new Bank{Id=3, Name="City Bank", Branch="Banani"},
            new Bank{Id=4, Name="Brac Bank", Branch="Uttara"},
            new Bank{Id=5, Name="Prime Bank", Branch="Mirpur"},
            new Bank{Id=6, Name="AB Bank", Branch="Dhanmondi"},
            new Bank{Id=7, Name="Trust Bank", Branch="Mohakhali"},
            new Bank{Id=8, Name="IFIC Bank", Branch="Bashundhara"},
            new Bank{Id=9, Name="Standard Bank", Branch="Tejgaon"},
            new Bank{Id=10, Name="SouthEast Bank", Branch="Farmgate"},
            });

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n================== BANKS ==================");
            Console.ResetColor();
            Console.WriteLine($"{"Id",-5}{"Name",-25}{"Branch",-15}");
            Console.WriteLine(new string('-', 45));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            repoB.GetAll().ForEach(b =>
                Console.WriteLine($"{b.Id,-5}{b.Name,-25}{b.Branch,-15}")
            );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n============= BANK BY ID =============");
            Console.ResetColor();
            Console.WriteLine($"{"Id",-5}{"Name",-25}{"Branch",-15}");
            Console.WriteLine(new string('-', 45));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var bank = repoB.Get(2);
            Console.WriteLine($"{bank.Id,-5}{bank.Name,-25}{bank.Branch,-15}");
            Console.ResetColor();

            IRepo<Client> repoC = factory.CreateRepo<Client>();
            repoC.AddRange(new Client[]
            {
            new Client{Id=1, FullName="Tanvir Ahmed", AccountNumber="1001", Balance=50000, BankId=1},
            new Client{Id=2, FullName="Rafiul Islam", AccountNumber="1002", Balance=75000, BankId=2},
            new Client{Id=3, FullName="Nusrat Jahan", AccountNumber="1003", Balance=120000, BankId=3},
            new Client{Id=4, FullName="Sadia Rahman", AccountNumber="1004", Balance=65000, BankId=4},
            new Client{Id=5, FullName="Fahim Hasan", AccountNumber="1005", Balance=82000, BankId=5},
            new Client{Id=6, FullName="Mehedi Hasan", AccountNumber="1006", Balance=47000, BankId=6},
            new Client{Id=7, FullName="Shamim Reza", AccountNumber="1007", Balance=99000, BankId=7},
            new Client{Id=8, FullName="Mim Chowdhury", AccountNumber="1008", Balance=103000, BankId=8},
            new Client{Id=9, FullName="Rashed Khan", AccountNumber="1009", Balance=58000, BankId=9},
            new Client{Id=10, FullName="Tania Akter", AccountNumber="1010", Balance=76000, BankId=10},
            });

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n================== CLIENTS ==================");
            Console.ResetColor();
            Console.WriteLine($"{"Id",-5}{"Name",-20}{"Account",-10}{"Balance",-15}{"BankId",-7}");
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            repoC.GetAll().ForEach(c =>
                Console.WriteLine($"{c.Id,-5}{c.FullName,-20}{c.AccountNumber,-10}{c.Balance.ToString("C0"),-15}{c.BankId,-7}")
            );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n============= UPDATE CLIENT BALANCE =============");
            Console.ResetColor();
            var client = repoC.Get(2);
            client.Balance += 5000;
            repoC.Update(client);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Updated Client: {client.FullName} | New Balance: {client.Balance:C0}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n============= DELETE CLIENT =============");
            Console.ResetColor();
            repoC.Delete(1);
            Console.WriteLine($"{"Id",-5}{"Name",-20}{"Account",-10}{"Balance",-15}{"BankId",-7}");
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            repoC.GetAll().ForEach(c =>
                Console.WriteLine($"{c.Id,-5}{c.FullName,-20}{c.AccountNumber,-10}{c.Balance.ToString("C0"),-15}{c.BankId,-7}")
            );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n============= END OF TEST =============");
            Console.ResetColor();
        }
    }
}


