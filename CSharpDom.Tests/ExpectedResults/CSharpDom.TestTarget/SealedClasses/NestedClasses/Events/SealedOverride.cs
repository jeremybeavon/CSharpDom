namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events
{
    public sealed class SealedClassWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
