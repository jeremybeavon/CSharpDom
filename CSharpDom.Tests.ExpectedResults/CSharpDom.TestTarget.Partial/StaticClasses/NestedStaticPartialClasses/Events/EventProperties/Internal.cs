namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticPartialClassWithInternalEventProperty
    {
        public static partial class Class
        {
            internal static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
