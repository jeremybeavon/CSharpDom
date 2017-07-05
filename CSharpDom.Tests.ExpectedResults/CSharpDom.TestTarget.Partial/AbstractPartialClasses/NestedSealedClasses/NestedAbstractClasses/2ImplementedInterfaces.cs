namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
