namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events
{
    public class ClassWithNestedAbstractClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
