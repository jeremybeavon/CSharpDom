namespace CSharpDom.TestTarget.Classes.EventProperties
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
