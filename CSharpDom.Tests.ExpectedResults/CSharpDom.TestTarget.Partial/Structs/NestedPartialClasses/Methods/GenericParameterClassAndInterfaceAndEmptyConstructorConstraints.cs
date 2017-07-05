namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
