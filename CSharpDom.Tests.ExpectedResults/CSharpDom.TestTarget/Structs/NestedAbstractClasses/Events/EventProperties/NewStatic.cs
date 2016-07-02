namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithNewStaticEventProperty
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
