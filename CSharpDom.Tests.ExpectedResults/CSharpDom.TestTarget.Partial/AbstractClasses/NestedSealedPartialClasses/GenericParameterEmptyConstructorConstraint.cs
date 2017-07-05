namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
