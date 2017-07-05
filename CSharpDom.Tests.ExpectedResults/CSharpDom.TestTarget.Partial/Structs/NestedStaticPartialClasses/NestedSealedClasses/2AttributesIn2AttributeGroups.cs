namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWith2AttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
