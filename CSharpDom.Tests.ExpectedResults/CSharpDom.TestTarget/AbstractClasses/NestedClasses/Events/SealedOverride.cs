namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events
{
    public abstract class AbstractClassWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
