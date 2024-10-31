using Candidate_BussinessObjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface IJobPostingRepositories
    {
        public JobPosting GetJobPostingByID(string jobid);
        public List<JobPosting> GetJobPostings();

        public bool updateJobPosting(JobPosting jobPosting);
        public bool deleteJobPosting(string postingID);
        public bool AddJobPosting(JobPosting jobPosting);
    }
}
