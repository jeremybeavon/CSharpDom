namespace CSharpDom.TestTarget.Classes.EventProperties
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
