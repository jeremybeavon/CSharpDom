namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
