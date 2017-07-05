namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithEventPropertyWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
