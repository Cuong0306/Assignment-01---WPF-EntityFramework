using Candidate_BussinessObjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface IHRAccountServices
    {
        public Hraccount GetHraccountByMail(string email);

        public List<Hraccount> GetHraccount();
    }
}
