namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses
{
    public class ClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
