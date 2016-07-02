namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
