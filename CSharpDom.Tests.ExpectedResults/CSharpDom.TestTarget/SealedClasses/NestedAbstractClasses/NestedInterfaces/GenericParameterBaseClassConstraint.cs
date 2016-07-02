namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
