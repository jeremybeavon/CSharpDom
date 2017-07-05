namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events
{
    public class ClassWithNestedAbstractPartialClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
