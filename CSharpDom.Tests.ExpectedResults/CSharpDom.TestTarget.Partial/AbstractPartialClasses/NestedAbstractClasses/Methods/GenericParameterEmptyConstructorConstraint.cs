namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
