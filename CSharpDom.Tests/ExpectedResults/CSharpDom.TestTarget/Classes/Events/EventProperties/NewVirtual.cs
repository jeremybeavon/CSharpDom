namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithNewVirtualEventProperty : BaseClassWithEvent
    {
        public new virtual event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
