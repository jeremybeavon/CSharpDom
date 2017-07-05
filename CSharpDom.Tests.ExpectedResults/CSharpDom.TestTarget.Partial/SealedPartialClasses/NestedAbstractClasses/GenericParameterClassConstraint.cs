namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
