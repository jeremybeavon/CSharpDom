namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStaticClasses
{
    public class ClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
