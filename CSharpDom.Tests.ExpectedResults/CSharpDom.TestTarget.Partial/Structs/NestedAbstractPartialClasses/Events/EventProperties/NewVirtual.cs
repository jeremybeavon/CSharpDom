namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractPartialClassWithNewVirtualEventProperty
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
