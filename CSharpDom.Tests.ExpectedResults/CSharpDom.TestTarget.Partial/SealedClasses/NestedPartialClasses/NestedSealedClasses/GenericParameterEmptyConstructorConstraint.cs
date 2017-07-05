namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
