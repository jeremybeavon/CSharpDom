namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithInternalEventProperty
    {
        public sealed class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
