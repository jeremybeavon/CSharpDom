namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithInternalEventProperty
    {
        public static partial class Class
        {
            internal static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
