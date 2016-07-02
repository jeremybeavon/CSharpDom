namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups
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
