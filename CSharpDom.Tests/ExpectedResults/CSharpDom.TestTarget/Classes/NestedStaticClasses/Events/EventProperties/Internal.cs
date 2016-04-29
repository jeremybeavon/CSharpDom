namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Events.EventProperties
{
    public class ClassWithNestedStaticClassWithInternalEventProperty
    {
        public static class Class
        {
            internal static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
