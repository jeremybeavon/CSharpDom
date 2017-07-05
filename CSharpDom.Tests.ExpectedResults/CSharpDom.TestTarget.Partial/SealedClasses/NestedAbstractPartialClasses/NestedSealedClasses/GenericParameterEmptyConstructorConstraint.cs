namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
