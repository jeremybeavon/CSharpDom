namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, IInterface, new()
        {
        }
    }
}
