namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint
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
