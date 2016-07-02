namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithSealedOverrideEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
