namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedClassWithNestedStaticClassWith2AttributesIn2AttributeGroups
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
