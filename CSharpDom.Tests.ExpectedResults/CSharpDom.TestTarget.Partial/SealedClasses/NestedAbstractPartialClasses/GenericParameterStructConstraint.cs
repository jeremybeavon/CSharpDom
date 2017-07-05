namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
