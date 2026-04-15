using _1291763.Factory_Layer;
using _1291763.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291763
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepoFactory repoFactory = new RepoFactory();
            TestClass test = new TestClass(repoFactory);
            test.Run();
            Console.ReadKey();
        }

    }
}


