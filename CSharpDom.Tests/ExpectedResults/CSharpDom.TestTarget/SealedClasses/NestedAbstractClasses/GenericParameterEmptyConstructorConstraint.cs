namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
