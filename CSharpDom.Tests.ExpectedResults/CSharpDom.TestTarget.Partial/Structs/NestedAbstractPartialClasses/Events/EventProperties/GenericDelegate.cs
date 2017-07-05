namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractPartialClassWithEventPropertyWithGenericDelegate
    {
        public abstract partial class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
