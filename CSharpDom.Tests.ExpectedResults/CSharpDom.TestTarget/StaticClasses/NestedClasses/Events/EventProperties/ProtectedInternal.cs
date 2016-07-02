namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithProtectedInternalEventProperty
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
