namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
