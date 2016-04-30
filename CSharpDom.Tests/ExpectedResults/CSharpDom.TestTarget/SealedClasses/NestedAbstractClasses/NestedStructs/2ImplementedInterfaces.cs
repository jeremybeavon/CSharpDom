namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
