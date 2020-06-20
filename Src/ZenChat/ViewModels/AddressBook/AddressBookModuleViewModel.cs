using System.ComponentModel.Composition;
using ZenChat.ViewModels.AddressBook.Contact;
using ZenChat.ViewModels.AddressBook.Group;

namespace ZenChat.ViewModels.AddressBook
{
    [Export]
    public class AddressBookModuleViewModel : Module
    {
        public override string Name
        {
            get { return "AddressBookModule"; }
        }

        public override string Desc
        {
            get { return "通讯录"; }
        }

        public AddressBookContactViewModel Contact { get; set; }

        public AddressBookGroupViewModel Group { get; set; }

        [ImportingConstructor]
        public AddressBookModuleViewModel(
            AddressBookContactViewModel contact,
            AddressBookGroupViewModel group)
        {
            Contact = contact;
            Group = group;
        }
    }
}