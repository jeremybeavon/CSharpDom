namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithProtectedEventProperty
    {
        public abstract class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
