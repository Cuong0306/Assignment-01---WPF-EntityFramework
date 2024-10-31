using Candidate_BussinessObjs;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepositories jobPostingRepositories;

        public JobPostingService()
        {
            jobPostingRepositories = new JobPostingRepositories();
        }
        public JobPosting GetJobPostingByID(string jobid)
        {
            return jobPostingRepositories.GetJobPostingByID(jobid);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jobPostingRepositories.GetJobPostings();
        }
        public bool updateJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepositories.updateJobPosting(jobPosting);
        }
        public bool deleteJobPosting(string postingID)
        {
            return jobPostingRepositories.deleteJobPosting(postingID);
        }
        public bool AddJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepositories.AddJobPosting(jobPosting);
        }
    }
}
