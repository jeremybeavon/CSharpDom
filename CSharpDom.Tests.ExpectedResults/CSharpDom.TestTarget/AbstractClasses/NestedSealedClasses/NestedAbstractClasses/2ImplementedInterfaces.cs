namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
