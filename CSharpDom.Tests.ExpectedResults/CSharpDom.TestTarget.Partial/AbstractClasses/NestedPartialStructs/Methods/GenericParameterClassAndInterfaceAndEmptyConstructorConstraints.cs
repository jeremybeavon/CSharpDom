namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
