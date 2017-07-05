namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedPartialClassWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
