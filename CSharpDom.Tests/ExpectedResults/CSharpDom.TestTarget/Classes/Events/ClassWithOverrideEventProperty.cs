namespace CSharpDom.TestTarget.Classes.Events
{
    public class ClassWithOverrideEventProperty : BaseClassWithEvent
    {
        public override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
