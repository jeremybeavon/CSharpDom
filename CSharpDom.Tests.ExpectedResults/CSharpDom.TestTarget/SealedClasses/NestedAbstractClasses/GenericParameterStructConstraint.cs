namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
