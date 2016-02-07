namespace CSharpDom.TestTarget.Classes.EventProperties
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
