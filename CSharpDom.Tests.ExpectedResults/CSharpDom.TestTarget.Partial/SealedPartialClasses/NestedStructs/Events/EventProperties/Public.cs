namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStructWithPublicEventProperty
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
