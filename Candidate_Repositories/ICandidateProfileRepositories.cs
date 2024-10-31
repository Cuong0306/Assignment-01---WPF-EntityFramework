using Candidate_BussinessObjs;
using Candidate_DAOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface ICandidateProfileRepositories
    {
        public List<CandidateProfile> GetCandidateProfiles();
        public CandidateProfile GetCandidateProfile(string id);
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool DeleteCandidateProfile(string candidateID);
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);



    }
}
