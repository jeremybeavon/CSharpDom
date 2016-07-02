namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithNewEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
