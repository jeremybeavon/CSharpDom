namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedSealedClassWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
