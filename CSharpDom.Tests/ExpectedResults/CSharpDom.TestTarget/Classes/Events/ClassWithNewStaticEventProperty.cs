namespace CSharpDom.TestTarget.Classes.Events
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
