namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedClassWithNestedAbstractClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public abstract class NestedClass
            {
            }
        }
    }
}
