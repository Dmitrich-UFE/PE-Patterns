using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class PremiumProxy: PremiumService
    {
        PremiumService premiumService;

        Content PremiumService.GetPremiumContent(User user) 
        {
            if (user.HasPremium)
            {
                Console.WriteLine("Премиум прокси: проходи");
                return premiumService.GetPremiumContent(user);
            }
            
            Console.WriteLine("Премиум прокси: туда нельзя без премиума");
            return null;
        }

        internal PremiumProxy(PremiumService premiumService)
        {
            this.premiumService = premiumService;
        }
    }
}
