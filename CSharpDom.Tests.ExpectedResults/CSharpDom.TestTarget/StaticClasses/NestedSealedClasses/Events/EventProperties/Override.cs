namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithOverrideEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
