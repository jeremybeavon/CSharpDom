namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
