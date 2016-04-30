namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
