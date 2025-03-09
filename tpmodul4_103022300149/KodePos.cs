using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300149
{
    class KodePos
    {
        public string GetKodePos(string kelurahan)
        {
            Dictionary<string, string> kodePos = new Dictionary<string, string>
            {
                { "Cibeunying Kaler", "40111" },
                { "Cibeunying Kidul", "40112" },
                { "Cihaurgeulis", "40113" },
                { "Citarum", "40114" },
                { "Batununggal", "40266" },
                { "Kujangsari", "40287" },
                { "Mengger", "40267" },
                { "Wates", "40256" },
                { "Cijagra", "40287" },
                { "Jatisari", "40286" },
                { "Margasari", "40286" },
                { "Sekejati", "40286" },
                { "Kebonwaru", "40272" },
                { "Maleer", "40274" },
                { "Samoja", "40273" }
            };
            return kodePos.ContainsKey(kelurahan) ? kodePos[kelurahan] : "Kode pos tidak ditemukan";
        }
    }
}
