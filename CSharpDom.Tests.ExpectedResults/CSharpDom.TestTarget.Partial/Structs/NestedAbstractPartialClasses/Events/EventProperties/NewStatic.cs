namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractPartialClassWithNewStaticEventProperty
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
