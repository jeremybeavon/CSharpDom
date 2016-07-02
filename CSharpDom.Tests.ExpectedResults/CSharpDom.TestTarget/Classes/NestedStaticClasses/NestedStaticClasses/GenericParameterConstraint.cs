namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
