namespace CSharpDom.TestTarget.Classes.Events.EventProperties
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
