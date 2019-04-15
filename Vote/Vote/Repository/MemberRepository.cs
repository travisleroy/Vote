using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.VoteData; //added
using System.Data.SqlClient; //added
using Microsoft.Extensions.Configuration; //added
using Dapper; //added

namespace Vote.Repository
{
    public class MemberRepository : IMemberRepository
    {
        //START.  
        IConfiguration _configuration;

        public MemberRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("GsaConnectionString").Value;
            return connection;
        }
        //END.  


        //START
        public List<clsMemberInformation> GetAllMembersList()
        {
            var connectionString = this.GetConnection();
            List<clsMemberInformation> MyGetAllMembersListVariable = new List<clsMemberInformation>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MyGetAllMembersListVariable = con.Query<clsMemberInformation>("SELECT * FROM TblMembers").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return MyGetAllMembersListVariable;
            }
        }
        //END 

    }
}
