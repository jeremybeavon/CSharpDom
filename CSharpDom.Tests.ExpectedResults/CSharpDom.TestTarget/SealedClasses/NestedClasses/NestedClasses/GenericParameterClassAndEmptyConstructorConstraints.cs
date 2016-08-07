namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
