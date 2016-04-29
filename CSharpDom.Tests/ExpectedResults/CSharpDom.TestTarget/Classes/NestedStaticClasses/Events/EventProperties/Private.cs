namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Events.EventProperties
{
    public class ClassWithNestedStaticClassWithPrivateEventProperty
    {
        public static class Class
        {
            private static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
