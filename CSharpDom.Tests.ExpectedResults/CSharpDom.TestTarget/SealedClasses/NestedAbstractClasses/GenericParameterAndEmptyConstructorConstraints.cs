namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
