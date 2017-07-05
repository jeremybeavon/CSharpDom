namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithPrivateEventProperty
    {
        public static partial class Class
        {
            private static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
