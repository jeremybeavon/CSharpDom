namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithInternalEventProperty
    {
        public class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
