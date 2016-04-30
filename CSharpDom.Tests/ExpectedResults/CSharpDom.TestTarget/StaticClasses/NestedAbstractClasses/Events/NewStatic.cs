namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events
{
    public static class StaticClassWithNestedAbstractClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
