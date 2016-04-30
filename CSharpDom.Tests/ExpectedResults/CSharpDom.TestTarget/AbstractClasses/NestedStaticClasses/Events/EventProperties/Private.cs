namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticClassWithPrivateEventProperty
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
