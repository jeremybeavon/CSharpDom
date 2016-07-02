namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Methods
{
    public class ClassWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
