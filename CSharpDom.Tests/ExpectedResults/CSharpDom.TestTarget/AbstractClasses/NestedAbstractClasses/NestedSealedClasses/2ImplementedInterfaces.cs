namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
