namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractClassWithNestedSealedClassWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
