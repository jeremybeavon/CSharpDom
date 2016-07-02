namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractClassWithNestedSealedClassWith1ImplementedInterface
    {
        public abstract class Class
        {
            public sealed class NestedClass : IInterface
            {
            }
        }
    }
}
