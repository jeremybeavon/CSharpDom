namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses
{
    public class ClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint
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
