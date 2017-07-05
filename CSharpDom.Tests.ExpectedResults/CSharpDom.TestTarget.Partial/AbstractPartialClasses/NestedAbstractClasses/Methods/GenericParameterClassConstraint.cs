namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
