namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
