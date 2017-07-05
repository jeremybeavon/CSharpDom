namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public static partial class Class
        {
            public static event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
