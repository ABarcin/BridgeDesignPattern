using BridgeDesignPattern.Implementor.Implementor;
using BridgeDesignPattern.Implementor.Mapper;
using BridgeDesignPattern.Implementor.VM;
using BridgeDesingPattern.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeDesignPattern.Implementor.Concrete
{
    public class CustomerContact : IContact
    {
        public string AddContact(ContactVM contact)
        {
            string message = "";
            using (Slytherin_AracIhaleEntities context = new Slytherin_AracIhaleEntities())
            {
                try
                {
                    context.KullaniciIletisim.Add(new CustomerMapper().ContactVMToCustomerContact(contact));
                    int isAdded = context.SaveChanges();
                    message = isAdded != 0 ? "Customer Contact Added.  Success" : "Fault";
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
            }
            return message;
        }
        public string DeleteContact(ContactVM contact)
        {
            string message = "";
            using (Slytherin_AracIhaleEntities context = new Slytherin_AracIhaleEntities())
            {
                try
                {
                    context.KullaniciIletisim.Remove(context.KullaniciIletisim.Find(contact.ContactID));
                    int isDeleted = context.SaveChanges();
                    message = isDeleted != 0 ? "Customer Contact Deleted.    Success" : " Customer Contact Not Found.     Fault";
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                
            }
            return message;
        }
        public List<ContactVM> GetAllContact()
        {
            List<ContactVM> contacts = new List<ContactVM>();
            using (Slytherin_AracIhaleEntities context = new Slytherin_AracIhaleEntities())
            {
                contacts = new CustomerMapper().CustomerContactListToContactVMList(context.KullaniciIletisim.ToList());
            }
            return contacts;
        }

        public string UpdateContact(ContactVM contact)
        {
            string message = "";
            using (Slytherin_AracIhaleEntities context = new Slytherin_AracIhaleEntities())
            {
                try
                {
                    KullaniciIletisim employeeContact=context.KullaniciIletisim.Find(contact.ContactID);
                    employeeContact.IletisimBilgi = contact.ContactInformation;
                    int isUpdated = context.SaveChanges();
                    message = isUpdated != 0 ? "Customer Contact Modified.     Success" : "Employe Contact Not Modified Because Same Values Or CustomerContact Not Found.     Fault";
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                
            }
            return message;
        }
    }
}
