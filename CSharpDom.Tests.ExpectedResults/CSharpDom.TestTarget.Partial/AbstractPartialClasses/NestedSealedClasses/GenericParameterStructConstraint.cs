namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
