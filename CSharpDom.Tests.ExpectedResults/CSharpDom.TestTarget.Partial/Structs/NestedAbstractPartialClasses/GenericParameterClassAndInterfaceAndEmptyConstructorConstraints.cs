namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
