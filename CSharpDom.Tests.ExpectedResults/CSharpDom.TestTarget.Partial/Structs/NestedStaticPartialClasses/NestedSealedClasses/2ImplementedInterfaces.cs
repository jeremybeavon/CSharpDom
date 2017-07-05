namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWith2ImplementedInterfaces
    {
        public static partial class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
