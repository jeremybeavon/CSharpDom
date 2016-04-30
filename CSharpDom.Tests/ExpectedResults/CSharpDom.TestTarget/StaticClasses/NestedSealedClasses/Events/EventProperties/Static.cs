namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithStaticEventProperty
    {
        public sealed class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
