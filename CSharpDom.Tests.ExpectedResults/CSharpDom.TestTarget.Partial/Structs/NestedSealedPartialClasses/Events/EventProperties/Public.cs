namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedSealedPartialClassWithPublicEventProperty
    {
        public sealed partial class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
