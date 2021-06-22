using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Helper
{
    public static class JsonReader
    {
        public static T LoadJson<T>(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                StringBuilder sb = new StringBuilder();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
                try
                {
                    return JsonConvert.DeserializeObject<T>(sb.ToString());
                }
                catch (System.Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
