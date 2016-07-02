namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public static class NestedClass
            {
            }
        }
    }
}
