namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticClassWithPublicEventProperty
    {
        public static class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
