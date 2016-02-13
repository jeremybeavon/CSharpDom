namespace CSharpDom.TestTarget.Classes.Events.EventProperties
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
