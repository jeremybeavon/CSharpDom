namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events
{
    public struct StructWithNestedStaticPartialClassWithEventWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
