namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
