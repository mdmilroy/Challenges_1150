using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    public class ClaimsRepo
    {
        public List<Claim> _claims = new List<Claim>();
        public List<Claim> _claimsHandled = new List<Claim>();

        public void ViewAllClaims()
        {
            
        }

        public void HandleNextClaim()
        {
            
        }

        public void CreateNewClaim(Claim claimToAdd)
        {
            _claims.Add(claimToAdd);
        }

        public void ViewHandledClaims()
        {
           
        }
    }
}
