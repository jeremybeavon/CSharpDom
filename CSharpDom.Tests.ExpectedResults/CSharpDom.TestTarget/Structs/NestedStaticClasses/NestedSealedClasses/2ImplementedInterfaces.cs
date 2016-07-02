namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public static class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
