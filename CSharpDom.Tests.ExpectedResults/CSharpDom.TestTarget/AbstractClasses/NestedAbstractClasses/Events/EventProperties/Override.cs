namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
