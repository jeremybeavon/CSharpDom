namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithNestedSealedClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
