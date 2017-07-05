namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods
{
    public struct StructWithNestedAbstractPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
