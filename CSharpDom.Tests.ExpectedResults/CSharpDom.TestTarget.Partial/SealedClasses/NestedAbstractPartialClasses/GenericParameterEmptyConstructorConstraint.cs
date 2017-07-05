namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
