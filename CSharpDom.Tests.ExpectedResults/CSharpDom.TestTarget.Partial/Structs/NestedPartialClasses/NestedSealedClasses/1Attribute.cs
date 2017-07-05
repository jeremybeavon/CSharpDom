namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedPartialClassWithNestedSealedPartialClassWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
