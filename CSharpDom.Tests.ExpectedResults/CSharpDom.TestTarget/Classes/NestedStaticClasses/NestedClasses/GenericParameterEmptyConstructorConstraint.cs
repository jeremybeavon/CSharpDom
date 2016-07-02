namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses
{
    public class ClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
