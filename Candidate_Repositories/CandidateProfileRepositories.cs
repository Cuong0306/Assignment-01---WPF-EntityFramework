using Candidate_BussinessObjs;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class CandidateProfileRepositories : ICandidateProfileRepositories
    {
        public bool AddCandidateProfile(CandidateProfile candidateProfile)=>CandidateProfileDAOs.Instance.AddCandidateProfile(candidateProfile);
        public bool DeleteCandidateProfile(string candidateID)=>CandidateProfileDAOs.Instance.DeleteCandidateProfile(candidateID);
        public CandidateProfile GetCandidateProfile(string id)=>CandidateProfileDAOs.Instance.GetCandidateProfile(id);
        public List<CandidateProfile> GetCandidateProfiles()=>CandidateProfileDAOs.Instance.GetCandidateProfiles();
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)=>CandidateProfileDAOs.Instance.UpdateCandidateProfile(candidateProfile);  
        
    }
}
