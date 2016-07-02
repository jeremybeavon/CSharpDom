namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events
{
    public class ClassWithNestedAbstractClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
