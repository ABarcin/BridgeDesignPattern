using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Implementor.VM
{
    public class ContactVM
    {
        public int ContactID { get; set; }
        public int UserID { get; set; }
        public int ContactTypeID { get; set; }
        public string ContactInformation { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
