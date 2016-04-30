namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
