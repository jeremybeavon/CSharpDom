namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
