namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithVirtualEventProperty
    {
        public abstract class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
