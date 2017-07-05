namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStructWithEventPropertyWithGenericDelegate
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
