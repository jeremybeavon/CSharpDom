namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
