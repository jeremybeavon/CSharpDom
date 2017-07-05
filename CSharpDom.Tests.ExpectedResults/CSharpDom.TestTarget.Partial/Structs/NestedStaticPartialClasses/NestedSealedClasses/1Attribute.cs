namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
