using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vote.Repository; //added

namespace Vote.Pages
{
    public class IndexModel : PageModel
    {
        IMemberRepository TheMemberRepository;
        public IndexModel(IMemberRepository MyMemberRepository)
        {
            TheMemberRepository = MyMemberRepository;
        }

        [BindProperty]
        public List<VoteData.clsMemberInformation> VarForMemberList { get; set; }

        public void OnGet()
        {
            VarForMemberList = TheMemberRepository.GetAllMembersList();
        }
    }
}