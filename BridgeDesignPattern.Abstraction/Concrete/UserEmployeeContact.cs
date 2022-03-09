using BridgeDesignPattern.Abstraction.Abstraction;
using BridgeDesignPattern.Implementor.Implementor;
using BridgeDesignPattern.Implementor.VM;
using System;
using System.Collections.Generic;

namespace BridgeDesignPattern.Abstraction.Concrete
{
    public class UserEmployeeContact : UserContact
    {
        public UserEmployeeContact(IContact contact):base(contact)
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
