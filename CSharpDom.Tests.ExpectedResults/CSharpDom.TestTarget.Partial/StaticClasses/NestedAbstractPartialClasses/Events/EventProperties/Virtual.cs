namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractPartialClassWithVirtualEventProperty
    {
        public abstract partial class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
