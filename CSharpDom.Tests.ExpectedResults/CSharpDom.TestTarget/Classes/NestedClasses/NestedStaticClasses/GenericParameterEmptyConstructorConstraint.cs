namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStaticClasses
{
    public class ClassWithNestedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
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
