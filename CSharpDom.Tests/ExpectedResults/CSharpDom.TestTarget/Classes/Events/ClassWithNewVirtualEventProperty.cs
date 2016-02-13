namespace CSharpDom.TestTarget.Classes.Events
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
