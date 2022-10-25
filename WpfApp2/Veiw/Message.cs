using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Veiw
{
    public class Message
    {
        public Message(string? context, DateTime dateTime)
        {
            Context = context;
            DateTime = dateTime.ToLongTimeString();
        }

        public string? Context { get; set; }
        public string DateTime { get; set; }


        public override string ToString()
        {
            return $"{Context} {DateTime}";
        }

    }
}
