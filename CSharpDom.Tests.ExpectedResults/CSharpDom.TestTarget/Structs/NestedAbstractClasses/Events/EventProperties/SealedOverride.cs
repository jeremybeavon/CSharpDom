namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithSealedOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
