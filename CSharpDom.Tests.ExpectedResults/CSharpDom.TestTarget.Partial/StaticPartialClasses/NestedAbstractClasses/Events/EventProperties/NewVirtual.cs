namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNewVirtualEventProperty
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
