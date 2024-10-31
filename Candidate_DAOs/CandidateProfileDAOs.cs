using Candidate_BussinessObjs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class CandidateProfileDAOs
    {
        private CandidateManagementContext dbContext;
        private static CandidateProfileDAOs instance;

        public static CandidateProfileDAOs Instance        {
            get
            {
                if(instance == null)
                {
                    instance = new CandidateProfileDAOs(); 
                }
                return instance;
            }
        }
        public CandidateProfileDAOs()
        {
            dbContext = new CandidateManagementContext();
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return dbContext.CandidateProfiles.ToList();
        }

        public CandidateProfile GetCandidateProfile(string id)
        {
            return dbContext.CandidateProfiles.SingleOrDefault(m => m.CandidateId.Equals(id));
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = GetCandidateProfile(candidateProfile.CandidateId);

            if (candidate == null)
                {
                    dbContext.CandidateProfiles.Add(candidateProfile);
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
                return isSuccess;
            
            }

        public bool DeleteCandidateProfile(string candidateID)
        {
            bool isSuccess = false;
            CandidateProfile candidate = GetCandidateProfile(candidateID);
            if(candidate != null)
            {
                dbContext.CandidateProfiles.Remove(candidate);
                dbContext.SaveChanges();
                isSuccess = true;
            }
            return isSuccess;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile) 
        {
            bool isSuccess = false;
            CandidateProfile candidate = GetCandidateProfile(candidateProfile.CandidateId);
            if (candidate != null)
            {
               
                dbContext.Entry<CandidateProfile>(candidateProfile).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
                isSuccess = true;
            }
            return isSuccess;
        }


    }
}
