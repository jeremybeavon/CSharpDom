namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
