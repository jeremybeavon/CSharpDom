namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedPartialClassWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
