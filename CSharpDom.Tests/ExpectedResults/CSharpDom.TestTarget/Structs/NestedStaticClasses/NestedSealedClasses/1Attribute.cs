namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticClassWithNestedSealedClassWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
