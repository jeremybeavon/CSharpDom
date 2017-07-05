namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods
{
    public partial class PartialClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint
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
