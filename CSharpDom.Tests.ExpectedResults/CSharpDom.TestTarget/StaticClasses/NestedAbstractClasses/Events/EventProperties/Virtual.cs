namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithVirtualEventProperty
    {
        public abstract class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
