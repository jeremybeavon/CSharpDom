namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedSealedClasses
{
    public partial class PartialClassWithNestedStructWithNestedSealedClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
