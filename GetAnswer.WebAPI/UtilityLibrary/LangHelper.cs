using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public static class LangHelper
    {
        public static char[] GetAzAlphabetUpper()
        {
            return new char[] { 'A','B','C','Ç','D','E','F','G','Ğ','H','X','I','İ','A','J','K',
                                'Q','L','M','N','O','Ö' ,'P','R','S','Ş','T','U','Ü','V','Y','Z'};
        }

        public static char[] GetAzAlphabetLower()
        {
            return new char[] { 'a','b','c','ç','d','e','f','g','ğ','h','x','ı','i','a','j','k',
                                'q','l','m','n','o','ö' ,'p','r','s','ş','t','u','ü','v','y','z'};
        }
    }
}
