namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStructWith2ImplementedInterfaces
    {
        public abstract partial class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
