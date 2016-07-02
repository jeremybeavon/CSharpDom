namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}
