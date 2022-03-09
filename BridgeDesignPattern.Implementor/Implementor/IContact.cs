using BridgeDesignPattern.Implementor.VM;
using System.Collections.Generic;

namespace BridgeDesignPattern.Implementor.Implementor
{
    public interface IContact
    {
        string AddContact(ContactVM contact);
        List<ContactVM> GetAllContact();
        string UpdateContact(ContactVM contact);
        string DeleteContact(ContactVM contact);
    }
}
