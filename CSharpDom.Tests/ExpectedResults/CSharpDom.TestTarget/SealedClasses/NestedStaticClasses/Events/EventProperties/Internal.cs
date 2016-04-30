namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticClassWithInternalEventProperty
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
