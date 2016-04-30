namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithProtectedEventProperty
    {
        public sealed class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
