namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractPartialClassWithNewEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
