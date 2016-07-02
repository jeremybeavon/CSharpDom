namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties
{
    public class ClassWithNestedClassWithProtectedInternalEventProperty
    {
        public class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
