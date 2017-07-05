namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithPublicEventProperty
    {
        public static partial class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
