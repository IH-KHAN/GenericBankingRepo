using _1291763.Models;
using _1291763.Repository_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291763.Factory_Layer
{
    public class RepoFactory : IRepoFactory
    {
        public IRepo<T> CreateRepo<T>() where T : BaseEntry
        {
            return new GenericRepo<T>();
        }
    }
}


