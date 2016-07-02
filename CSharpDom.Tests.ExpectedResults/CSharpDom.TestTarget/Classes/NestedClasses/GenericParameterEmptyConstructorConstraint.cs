namespace CSharpDom.TestTarget.Classes.NestedClasses
{
    public class ClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
