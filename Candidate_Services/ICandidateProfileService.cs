using Candidate_BussinessObjs;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface ICandidateProfileService
    {
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool DeleteCandidateProfile(string candidateID);
        public CandidateProfile GetCandidateProfile(string id);
        public List<CandidateProfile> GetCandidateProfiles();
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);
        
    }
}
