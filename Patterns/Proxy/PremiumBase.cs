using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class PremiumBase: PremiumService
    {
        private Content _premiumContent;
        
        internal PremiumBase(Content premiumContent) { _premiumContent = premiumContent; }

        Content PremiumService.GetPremiumContent(User user) 
        {
            Console.WriteLine("Премиум база: Доступ к премиум контенту получен");
            return _premiumContent;
        }
    }
}
