using Candidate_BussinessObjs;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class JobPostingRepositories : IJobPostingRepositories
    {
        public JobPosting GetJobPostingByID(string jobid)=>JobPostingDAOs.Instance.GetJobPostingsByID(jobid);
        

        public List<JobPosting> GetJobPostings()=>JobPostingDAOs.Instance.GetJobPostings();

        public bool updateJobPosting(JobPosting jobPosting) => JobPostingDAOs.Instance.updateJobPosting(jobPosting);
        public bool deleteJobPosting(string postingID) => JobPostingDAOs.Instance.deleteJobPosting(postingID);
        public bool AddJobPosting(JobPosting jobPosting) => JobPostingDAOs.Instance.AddJobPosting(jobPosting);

        
    }
}
