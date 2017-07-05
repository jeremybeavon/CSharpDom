namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
