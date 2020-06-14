using ZenChat.ViewModels;

namespace ZenChat.Events
{
    public class ModuleListItemSelectedEventArgs
    {
        public ModuleListItemViewModel Sender { get; private set; }

        public ModuleListItemSelectedEventArgs(ModuleListItemViewModel sender)
        {
            Sender = sender;
        }
    }
}