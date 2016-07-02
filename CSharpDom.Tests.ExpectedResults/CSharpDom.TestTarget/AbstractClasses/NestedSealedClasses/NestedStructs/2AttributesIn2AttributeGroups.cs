namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups
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
