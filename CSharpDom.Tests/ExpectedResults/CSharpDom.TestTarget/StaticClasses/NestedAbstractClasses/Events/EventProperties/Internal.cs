namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithInternalEventProperty
    {
        public abstract class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
