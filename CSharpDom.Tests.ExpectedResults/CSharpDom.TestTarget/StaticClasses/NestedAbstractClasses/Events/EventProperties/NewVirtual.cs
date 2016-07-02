namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithNewVirtualEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
