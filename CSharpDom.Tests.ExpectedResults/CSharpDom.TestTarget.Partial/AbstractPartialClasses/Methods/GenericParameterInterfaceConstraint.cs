namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}
