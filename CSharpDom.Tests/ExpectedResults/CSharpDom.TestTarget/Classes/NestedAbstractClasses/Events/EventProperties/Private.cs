namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithPrivateEventProperty
    {
        public abstract class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
