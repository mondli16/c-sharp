using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class EmailTask :ITask<string>
    {
        public string Message { get; set; }
        public string Recipient { get; set; }

        public string Perform()
        {
            return $"Email send to {Recipient} with message {Message}";
        }
    }
}
