using Candidate_BussinessObjs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class JobPostingDAOs
    {
        private CandidateManagementContext dbContext;
        private static JobPostingDAOs instance;
        public static JobPostingDAOs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAOs();
                }
                return instance;
            }
        }
        public JobPostingDAOs()
        {
            dbContext = new CandidateManagementContext();
        }
        public List<JobPosting> GetJobPostings()
        {
            return dbContext.JobPostings.ToList();
        }

        public JobPosting GetJobPostingsByID(string jobid)
        {
            return dbContext.JobPostings.SingleOrDefault(m => m.PostingId.Equals(jobid));
        }
        public bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPosting1 = GetJobPostingsByID(jobPosting.PostingId);
            if (jobPosting1 == null)
            {
                dbContext.JobPostings.Add(jobPosting);
                dbContext.SaveChanges();
                isSuccess = true;

            }
            return isSuccess;
        }

        public bool deleteJobPosting(string postingID)
        {
            bool isSuccess = false;
            JobPosting jobPosting = GetJobPostingsByID(postingID);

            // Check if the job posting exists before attempting to delete it
            if (jobPosting != null)
            {
                dbContext.JobPostings.Remove(jobPosting);
                dbContext.SaveChanges();
                isSuccess = true; // Mark as success since the deletion was performed
            }

            return isSuccess; // Return whether the deletion was successful
        }


        public bool updateJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPosting1 = GetJobPostingsByID(jobPosting.PostingId);
            if (jobPosting1 != null)
            {
                dbContext.Entry<JobPosting>(jobPosting).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
                isSuccess = true;

            }
            return isSuccess;
        }
    }
}
