namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedSealedClasses
{
    public class ClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
