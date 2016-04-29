namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
