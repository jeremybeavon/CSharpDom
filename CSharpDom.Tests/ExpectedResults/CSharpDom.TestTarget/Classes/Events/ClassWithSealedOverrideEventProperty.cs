namespace CSharpDom.TestTarget.Classes.Events
{
    public class ClassWithSealedOverrideEventProperty : BaseClassWithEvent
    {
        public sealed override event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
