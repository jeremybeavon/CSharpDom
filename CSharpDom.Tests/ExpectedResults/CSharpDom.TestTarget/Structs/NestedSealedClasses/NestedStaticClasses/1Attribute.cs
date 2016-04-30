namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedClassWithNestedStaticClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static class NestedClass
            {
            }
        }
    }
}
