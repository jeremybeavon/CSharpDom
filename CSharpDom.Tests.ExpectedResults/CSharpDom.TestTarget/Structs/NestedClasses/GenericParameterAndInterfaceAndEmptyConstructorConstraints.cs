namespace CSharpDom.TestTarget.Structs.NestedClasses
{
    public struct StructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
