namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStructWithStaticEventProperty
    {
        public struct Struct
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
