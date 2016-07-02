namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
