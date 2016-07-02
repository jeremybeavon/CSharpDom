namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticClassWithPrivateEventProperty
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
