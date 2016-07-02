namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticClassWithPublicEventProperty
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
