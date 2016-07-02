namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
