namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
