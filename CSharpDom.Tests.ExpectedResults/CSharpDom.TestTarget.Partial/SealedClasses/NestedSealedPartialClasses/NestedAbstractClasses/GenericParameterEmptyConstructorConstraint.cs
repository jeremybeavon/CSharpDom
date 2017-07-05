namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
