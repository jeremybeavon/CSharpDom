namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
