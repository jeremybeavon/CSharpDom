namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithProtectedEventProperty
    {
        public abstract class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
