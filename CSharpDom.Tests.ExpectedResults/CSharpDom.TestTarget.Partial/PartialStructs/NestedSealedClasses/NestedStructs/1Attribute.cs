namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithNestedSealedClassWithNestedStructWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
