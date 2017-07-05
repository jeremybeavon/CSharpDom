namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, new()
        {
        }
    }
}
