namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
