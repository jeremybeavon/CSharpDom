namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithNewVirtualEventProperty
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
