namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithProtectedInternalEventProperty
    {
        public sealed partial class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
