namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithPrivateEventProperty
    {
        public abstract class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
