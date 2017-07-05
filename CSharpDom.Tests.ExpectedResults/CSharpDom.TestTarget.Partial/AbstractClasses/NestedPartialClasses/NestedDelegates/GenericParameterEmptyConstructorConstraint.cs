namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
