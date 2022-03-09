using BridgeDesignPattern.Abstraction.Abstraction;
using BridgeDesignPattern.Implementor.Implementor;
using BridgeDesignPattern.Implementor.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Abstraction.Concrete
{
    public class UserCustomerContact:UserContact
    {
        public UserCustomerContact(IContact contact) : base(contact)
        {

        }
        public override string AddContact(ContactVM vm)
        {
            return _contact.AddContact(vm);
        }

        public override string DeleteContact(ContactVM vm)
        {
            return _contact.DeleteContact(vm);
        }

        public override List<ContactVM> GetAllContact()
        {
            return _contact.GetAllContact();
        }

        public override string UpdateContact(ContactVM vm)
        {
            return _contact.UpdateContact(vm);
        }
    }
}
