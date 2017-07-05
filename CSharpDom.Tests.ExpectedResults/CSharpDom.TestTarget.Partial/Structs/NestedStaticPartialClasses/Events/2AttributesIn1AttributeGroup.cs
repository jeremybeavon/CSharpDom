namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events
{
    public struct StructWithNestedStaticPartialClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
