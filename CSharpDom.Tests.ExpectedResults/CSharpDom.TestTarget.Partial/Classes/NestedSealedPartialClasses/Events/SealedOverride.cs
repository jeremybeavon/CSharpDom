namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events
{
    public class ClassWithNestedSealedPartialClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
