namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
