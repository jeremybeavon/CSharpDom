namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractPartialClassWithPublicEventProperty
    {
        public abstract partial class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
