namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
