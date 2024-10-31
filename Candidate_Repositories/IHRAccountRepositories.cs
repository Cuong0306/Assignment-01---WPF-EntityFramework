using Candidate_BussinessObjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface IHRAccountRepositories
    {
        public Hraccount GetHraccountByMail(string email);

        public List<Hraccount> GetHraccount();
    }
}
