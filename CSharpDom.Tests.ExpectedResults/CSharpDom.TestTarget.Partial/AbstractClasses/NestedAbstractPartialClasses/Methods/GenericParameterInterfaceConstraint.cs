namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
