using Candidate_BussinessObjs;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class HRAccountRepository : IHRAccountRepositories
    {
        public List<Hraccount> GetHraccount()=>HRAccountDAOs.Instance.GetHraccount();
        

        public Hraccount GetHraccountByMail(string email)=>HRAccountDAOs.Instance.GetHraccountByMail(email);
        
    }
}
