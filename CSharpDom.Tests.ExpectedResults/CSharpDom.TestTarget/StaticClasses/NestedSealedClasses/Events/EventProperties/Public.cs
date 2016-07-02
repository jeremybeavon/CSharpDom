namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithPublicEventProperty
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
