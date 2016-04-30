namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
