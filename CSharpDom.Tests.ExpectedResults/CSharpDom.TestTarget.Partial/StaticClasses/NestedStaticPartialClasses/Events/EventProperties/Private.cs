namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticPartialClassWithPrivateEventProperty
    {
        public static partial class Class
        {
            private static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
