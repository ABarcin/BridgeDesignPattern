using BridgeDesignPattern.Implementor.Implementor;
using BridgeDesignPattern.Implementor.Mapper;
using BridgeDesignPattern.Implementor.VM;
using BridgeDesingPattern.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeDesignPattern.Implementor.Concrete
{
    public class EmployeeContact : IContact
    {
        public string AddContact(ContactVM contact)
        {
            string message = "";
            using (Slytherin_AracIhaleEntities context=new Slytherin_AracIhaleEntities())
            {
                try
                {
                    context.CalisanIletisim.Add(new EmployeeMapper().ContactVMToEmployeeContact(contact));
                    int isAdded=context.SaveChanges();
                    message = isAdded != 0 ? "Employee Contact Added.  Success" : "Fault";
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
            using (Slytherin_AracIhaleEntities context=new Slytherin_AracIhaleEntities())
            {
                context.CalisanIletisim.Remove(context.CalisanIletisim.Find(contact.ContactID));
                int isDeleted = context.SaveChanges();
                message = isDeleted != 0 ? "Employee Contact Deleted.    Success" : " Employee Contact Not Found.     Fault";
            }
            return message;
        }
        public List<ContactVM> GetAllContact()
        {
            List<ContactVM> contacts = new List<ContactVM>();
            using (Slytherin_AracIhaleEntities context=new Slytherin_AracIhaleEntities())
            {
                contacts = new EmployeeMapper().EmployeeContactListToContactVMList(context.CalisanIletisim.ToList()) ;
            }
            return contacts;
        }

        public string UpdateContact(ContactVM contact)
        {
            string message = "";
            using (Slytherin_AracIhaleEntities context=new Slytherin_AracIhaleEntities())
            {
                CalisanIletisim employeeContact = context.CalisanIletisim.Find(contact.ContactID);
                employeeContact.IletisimBilgi = contact.ContactInformation;
                int isUpdated = context.SaveChanges();
                message = isUpdated != 0 ? "Employee Contact Modified.     Success" : "Employe Contact Not Modified Because Same Values Or EmployeeContact Not Found.     Fault";
            }
            return message;
        }
        
    }

}
