using Candidate_BussinessObjs;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class HRAccountServices : IHRAccountServices
    {
        private IHRAccountRepositories iAccountRepo;
        
        
        public List<Hraccount> GetHraccount()
        {
            return iAccountRepo.GetHraccount();
        }


        public Hraccount GetHraccountByMail(string email)
        {
            return iAccountRepo.GetHraccountByMail(email);
        }

        public HRAccountServices()
        {
            iAccountRepo = new HRAccountRepository();
        }

    }
}
