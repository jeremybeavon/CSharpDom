namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
