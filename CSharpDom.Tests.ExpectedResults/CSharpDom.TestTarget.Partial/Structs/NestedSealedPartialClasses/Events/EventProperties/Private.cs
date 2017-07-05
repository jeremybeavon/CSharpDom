namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedSealedPartialClassWithPrivateEventProperty
    {
        public sealed partial class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
