namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events
{
    public static class StaticClassWithNestedAbstractClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
