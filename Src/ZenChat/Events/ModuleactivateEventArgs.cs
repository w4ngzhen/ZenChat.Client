namespace ZenChat.Events
{
    public class ModuleActivateEventArgs
    {
        public Module TheModule { get; private set; }

        public ModuleActivateEventArgs(Module theModule)
        {
            TheModule = theModule;
        }
    }
}