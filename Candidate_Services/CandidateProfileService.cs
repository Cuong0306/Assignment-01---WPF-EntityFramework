using Candidate_BussinessObjs;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private readonly ICandidateProfileRepositories profileRepositories;

        public CandidateProfileService()
        {
            profileRepositories = new CandidateProfileRepositories();
        }
        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            return profileRepositories.AddCandidateProfile(candidateProfile);
        }

        public bool DeleteCandidateProfile(string candidateID)
        {
            return profileRepositories.DeleteCandidateProfile(candidateID);
        }

        public CandidateProfile GetCandidateProfile(string id)
        {
            return profileRepositories.GetCandidateProfile(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return profileRepositories.GetCandidateProfiles();
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            return profileRepositories.UpdateCandidateProfile(candidateProfile);
        }
        
    }
}
