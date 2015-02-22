using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PluralSightDownloader
{
    class JsonParser
    {

        private string _json;
        Dictionary<string, Dictionary<string, string>> main;

        public void DetermineCurrentChild(){
        
        }


        public void ExplodeJson(){
            main = new Dictionary<string, Dictionary<string, string>>();
            
            string[] firstSplitJson=_json.Split(':');

        }
    }
}
