namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
