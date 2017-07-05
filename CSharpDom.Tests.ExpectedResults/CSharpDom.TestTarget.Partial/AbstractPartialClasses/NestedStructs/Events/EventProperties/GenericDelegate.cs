namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithEventPropertyWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
