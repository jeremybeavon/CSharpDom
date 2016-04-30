namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedInterfaceWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public interface Interface : IInterface1, IInterface2
            {
            }
        }
    }
}
