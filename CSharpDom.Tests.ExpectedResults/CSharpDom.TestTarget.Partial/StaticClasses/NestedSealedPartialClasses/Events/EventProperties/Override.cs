namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithOverrideEventProperty
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
