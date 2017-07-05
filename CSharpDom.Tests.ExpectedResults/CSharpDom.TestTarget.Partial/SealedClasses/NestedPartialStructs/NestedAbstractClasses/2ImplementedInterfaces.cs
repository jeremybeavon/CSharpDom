namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStructWithNestedAbstractPartialClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
