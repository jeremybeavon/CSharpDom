namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, IInterface, new()
        {
        }
    }
}
