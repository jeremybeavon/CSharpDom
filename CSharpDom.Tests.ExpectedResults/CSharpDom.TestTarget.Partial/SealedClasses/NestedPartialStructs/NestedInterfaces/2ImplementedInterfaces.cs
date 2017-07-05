namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedInterfaces
{
    public sealed class SealedClassWithNestedStructWithNestedInterfaceWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
