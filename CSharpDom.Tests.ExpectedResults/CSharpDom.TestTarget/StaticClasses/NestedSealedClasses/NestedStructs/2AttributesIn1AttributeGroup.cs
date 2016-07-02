namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup
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
