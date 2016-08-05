namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
