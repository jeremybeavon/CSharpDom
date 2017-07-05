namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractPartialClassWithInternalEventProperty
    {
        public abstract partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
