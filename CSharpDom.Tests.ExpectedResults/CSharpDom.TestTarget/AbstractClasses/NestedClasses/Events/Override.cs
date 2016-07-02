namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events
{
    public abstract class AbstractClassWithNestedClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
