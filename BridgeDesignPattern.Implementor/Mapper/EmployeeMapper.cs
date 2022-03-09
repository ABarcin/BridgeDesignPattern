using BridgeDesignPattern.Implementor.VM;
using BridgeDesingPattern.Model.Model;
using System.Collections.Generic;

namespace BridgeDesignPattern.Implementor.Mapper
{
    public class EmployeeMapper
    {
        public ContactVM EmployeeContactToContactVM(CalisanIletisim employee)
        {
            return new ContactVM() { UserID = employee.CalisanID, ContactID = employee.CalisanIletisimID, ContactInformation = employee.IletisimBilgi, ContactTypeID = employee.IletisimTuruID, IsActive = employee.IsActive };
        }
        public CalisanIletisim ContactVMToEmployeeContact(ContactVM vm)
        {
            return new CalisanIletisim() { CalisanID = vm.UserID, CalisanIletisimID = vm.ContactID, IletisimBilgi = vm.ContactInformation, IletisimTuruID = vm.ContactTypeID, IsActive = vm.IsActive };
        }
        public List<ContactVM> EmployeeContactListToContactVMList(List<CalisanIletisim> contacts)
        {
            List<ContactVM> vms = new List<ContactVM>();
            foreach (var item in contacts)
            {
                vms.Add(EmployeeContactToContactVM(item));
            }
            return vms;
        }
        public List<CalisanIletisim> ContactVmListToEmployeeContactList(List<ContactVM> vms)
        {
            List<CalisanIletisim> contacts = new List<CalisanIletisim>();
            foreach (var item in vms)
            {
                contacts.Add(ContactVMToEmployeeContact(item));
            }
            return contacts;
        }
    }
}
