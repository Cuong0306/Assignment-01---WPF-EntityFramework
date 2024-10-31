using Candidate_BussinessObjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class HRAccountDAOs
    {
        private CandidateManagementContext context;

        private static HRAccountDAOs instance = null;

        public HRAccountDAOs()
        {
            context = new CandidateManagementContext();
        }

        public static HRAccountDAOs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAOs();
                }
                return instance;
            }
        }

        public Hraccount GetHraccountByMail(string email)
        {
            return context.Hraccounts.SingleOrDefault(m=>m.Email.Equals(email));
        }

        public List<Hraccount> GetHraccount()
        {
            return context.Hraccounts.ToList();
        }
    }
}
