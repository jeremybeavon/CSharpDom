namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
