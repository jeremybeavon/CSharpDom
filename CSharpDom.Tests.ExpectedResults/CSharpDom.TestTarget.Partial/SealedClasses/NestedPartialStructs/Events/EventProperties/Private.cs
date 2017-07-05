namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.EventProperties
{
    public sealed class SealedClassWithNestedStructWithPrivateEventProperty
    {
        public struct Struct
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
