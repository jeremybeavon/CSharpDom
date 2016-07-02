namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events
{
    public class ClassWithNestedAbstractClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
