namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
