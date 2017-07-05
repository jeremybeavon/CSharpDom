namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class<T>
            where T : BaseClass
        {
        }
    }
}
