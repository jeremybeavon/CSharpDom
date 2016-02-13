namespace CSharpDom.TestTarget.Classes.Events
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
