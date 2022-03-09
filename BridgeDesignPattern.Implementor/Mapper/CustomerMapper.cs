using BridgeDesignPattern.Implementor.VM;
using BridgeDesingPattern.Model.Model;
using System.Collections.Generic;

namespace BridgeDesignPattern.Implementor.Mapper
{
    public class CustomerMapper
    {
         public ContactVM CustomerContactToContactVM(KullaniciIletisim customer)
        {
            return new ContactVM() { UserID = customer.KullaniciID, ContactID = customer.KullaniciIletisimID, ContactInformation = customer.IletisimBilgi, ContactTypeID = customer.IletisimTuruID, IsActive = customer.IsActive };
        }
        public KullaniciIletisim ContactVMToCustomerContact(ContactVM vm)
        {
            return new KullaniciIletisim() { KullaniciID = vm.UserID, KullaniciIletisimID = vm.ContactID, IletisimBilgi = vm.ContactInformation, IletisimTuruID = vm.ContactTypeID, IsActive = vm.IsActive };
        }
        public List<ContactVM> CustomerContactListToContactVMList(List<KullaniciIletisim> contacts)
        {
            List<ContactVM> vms = new List<ContactVM>();
            foreach (var item in contacts)
            {
                vms.Add(CustomerContactToContactVM(item));
            }
            return vms;
        }
        public List<KullaniciIletisim> ContactVmListToCustomerContactList(List<ContactVM> vms)
        {
            List<KullaniciIletisim> contacts = new List<KullaniciIletisim>();
            foreach (var item in vms)
            {
                contacts.Add(ContactVMToCustomerContact(item));
            }
            return contacts;
        }
    }
}
