namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStaticClasses
{
    public class ClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
