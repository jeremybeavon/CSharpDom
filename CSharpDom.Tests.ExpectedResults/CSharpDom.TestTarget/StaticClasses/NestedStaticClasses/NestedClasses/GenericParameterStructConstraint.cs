namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
