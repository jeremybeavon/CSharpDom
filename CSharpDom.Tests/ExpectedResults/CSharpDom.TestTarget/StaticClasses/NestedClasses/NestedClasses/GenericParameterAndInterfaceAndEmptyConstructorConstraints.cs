namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
