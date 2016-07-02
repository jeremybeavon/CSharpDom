namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
