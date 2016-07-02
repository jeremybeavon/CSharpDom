namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithNewStaticEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
