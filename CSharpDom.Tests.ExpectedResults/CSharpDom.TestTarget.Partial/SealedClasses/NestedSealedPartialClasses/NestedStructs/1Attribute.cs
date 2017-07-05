namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedStructWith1Attribute
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
