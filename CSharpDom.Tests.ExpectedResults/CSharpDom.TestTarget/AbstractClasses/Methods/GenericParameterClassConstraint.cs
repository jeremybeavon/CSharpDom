namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterAbstractClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
