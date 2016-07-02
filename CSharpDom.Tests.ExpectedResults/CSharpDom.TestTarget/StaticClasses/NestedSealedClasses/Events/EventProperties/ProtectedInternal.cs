namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithProtectedInternalEventProperty
    {
        public sealed class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
