namespace CSharpDom.TestTarget.Classes.Events.EventProperties
{
    public class ClassWithNewStaticEventProperty : BaseClassWithEvent
    {
        public new static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
