namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate
    {
        public abstract class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
