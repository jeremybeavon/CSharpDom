namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithSealedOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
