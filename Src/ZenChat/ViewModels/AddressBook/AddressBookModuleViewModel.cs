using System.ComponentModel.Composition;
using ZenChat.ViewModels.AddressBook.Group;
using ZenChat.ViewModels.AddressBook.QueryBook;

namespace ZenChat.ViewModels.AddressBook
{
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

        public AddressBookGroupViewModel Group { get; set; }
        public AddressBookQueryBookViewModel QueryBook { get; set; }

        [ImportingConstructor]
        public AddressBookModuleViewModel(
            AddressBookGroupViewModel addressBookGroupViewModel, 
            AddressBookQueryBookViewModel addressBookQueryBookViewModel)
        {
            Group = addressBookGroupViewModel;
            QueryBook = addressBookQueryBookViewModel;
        }
    }
}