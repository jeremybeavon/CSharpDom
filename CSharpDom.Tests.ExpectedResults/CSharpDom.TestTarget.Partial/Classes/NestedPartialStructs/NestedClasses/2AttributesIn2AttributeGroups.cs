namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public class NestedClass
            {
            }
        }
    }
}
