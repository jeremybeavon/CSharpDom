namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
