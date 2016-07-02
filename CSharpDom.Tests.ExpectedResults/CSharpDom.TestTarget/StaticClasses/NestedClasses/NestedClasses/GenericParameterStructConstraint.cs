namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
