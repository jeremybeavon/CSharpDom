namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Methods
{
    public class ClassWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
