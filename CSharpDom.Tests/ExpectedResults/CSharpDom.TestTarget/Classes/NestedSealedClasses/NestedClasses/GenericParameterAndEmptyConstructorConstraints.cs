namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses
{
    public class ClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
