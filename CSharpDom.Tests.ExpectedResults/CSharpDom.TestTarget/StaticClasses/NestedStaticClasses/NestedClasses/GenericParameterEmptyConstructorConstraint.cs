namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
