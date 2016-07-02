namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
