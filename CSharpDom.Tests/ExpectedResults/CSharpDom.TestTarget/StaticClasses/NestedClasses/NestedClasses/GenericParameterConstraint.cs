namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
