namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithStaticEventProperty
    {
        public abstract class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
