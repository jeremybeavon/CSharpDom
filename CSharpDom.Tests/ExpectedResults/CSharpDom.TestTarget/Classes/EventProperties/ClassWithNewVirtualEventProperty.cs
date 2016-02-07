namespace CSharpDom.TestTarget.Classes.EventProperties
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
