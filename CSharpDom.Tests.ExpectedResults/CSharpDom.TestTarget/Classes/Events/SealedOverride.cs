namespace CSharpDom.TestTarget.Classes.Events
{
    public class ClassWithSealedOverrideEvent : BaseClassWithEvent
    {
        public sealed override event EventHandler Event;
    }
}
