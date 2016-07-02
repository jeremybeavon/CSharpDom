namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
