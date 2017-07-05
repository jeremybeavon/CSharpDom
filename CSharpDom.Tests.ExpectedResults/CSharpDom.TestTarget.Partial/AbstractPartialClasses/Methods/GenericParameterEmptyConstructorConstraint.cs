namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
