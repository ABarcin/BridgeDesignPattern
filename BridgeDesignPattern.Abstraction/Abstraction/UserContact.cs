using BridgeDesignPattern.Implementor.Implementor;
using BridgeDesignPattern.Implementor.VM;
using System.Collections.Generic;

namespace BridgeDesignPattern.Abstraction.Abstraction
{
    public abstract class UserContact
    {
        protected IContact _contact;
        public UserContact(IContact contact)
        {
            _contact = contact;
        }
        public abstract string AddContact(ContactVM vm);
        public abstract string UpdateContact(ContactVM vm);
        public abstract string DeleteContact(ContactVM vm);
        public abstract List<ContactVM> GetAllContact();

    }
}
