namespace CSharpDom.TestTarget.Classes.EventProperties
{
    public class ClassWithNewEventProperty : BaseClassWithEvent
    {
        public new event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
