namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
