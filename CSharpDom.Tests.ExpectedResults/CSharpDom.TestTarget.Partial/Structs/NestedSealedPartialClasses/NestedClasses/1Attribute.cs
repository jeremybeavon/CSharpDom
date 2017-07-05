namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
