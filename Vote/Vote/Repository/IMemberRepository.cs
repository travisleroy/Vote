using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.VoteData; //added

namespace Vote.Repository
{
    public interface IMemberRepository
    {
        List<clsMemberInformation> GetAllMembersList();
    }
}