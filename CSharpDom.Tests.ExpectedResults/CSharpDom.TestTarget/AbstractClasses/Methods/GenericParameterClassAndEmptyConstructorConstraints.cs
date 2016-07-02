namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterAbstractClassAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
