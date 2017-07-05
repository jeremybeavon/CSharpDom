namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWith2AttributesIn2AttributeGroups
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
