using BridgeDesignPattern.Abstraction.Concrete;
using BridgeDesignPattern.Implementor.Concrete;
using System;

namespace BridgeDesignPattern.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCustomerContact userCustomerContact = new UserCustomerContact(new CustomerContact());
            #region AddCustomerContact
            //var message = userCustomerContact.AddContact(new ContactVM() { UserID = 2, ContactTypeID = 2, ContactInformation = "05379810288", IsActive = true });
            //Console.WriteLine(message);
            #endregion
            #region GetAllCustomer
            //foreach (var item in userCustomerContact.GetAllContact())
            //{
            //    Console.WriteLine(item.ContactTypeID==1?"Email = ":"Phone = "+item.ContactInformation);
            //} 
            #endregion
            #region CustomerContactDelete
            //var message=userCustomerContact.DeleteContact(new ContactVM() { ContactID = 1});
            //Console.WriteLine(message); 
            #endregion
            #region CustomerContactUpdate
            //var message = userCustomerContact.UpdateContact(new ContactVM() { ContactID=2,ContactInformation = "05379810298"});
            //Console.WriteLine(message); 
            #endregion

            Console.ReadLine();
        }
    }
}
