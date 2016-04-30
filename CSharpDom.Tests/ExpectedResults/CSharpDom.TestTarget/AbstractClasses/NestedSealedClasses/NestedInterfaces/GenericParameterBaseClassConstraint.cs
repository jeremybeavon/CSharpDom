namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
