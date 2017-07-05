namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStructs
{
    public partial class PartialClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
