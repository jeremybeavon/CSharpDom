namespace CSharpDom.TestTarget.Classes.NestedClasses
{
    public class ClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
