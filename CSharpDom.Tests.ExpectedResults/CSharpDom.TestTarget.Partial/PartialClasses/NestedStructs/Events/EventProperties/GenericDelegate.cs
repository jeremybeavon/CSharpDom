namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.EventProperties
{
    public partial class PartialClassWithNestedStructWithEventPropertyWithGenericDelegate
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
