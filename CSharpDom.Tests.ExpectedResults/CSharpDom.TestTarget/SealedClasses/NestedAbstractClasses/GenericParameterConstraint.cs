namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
