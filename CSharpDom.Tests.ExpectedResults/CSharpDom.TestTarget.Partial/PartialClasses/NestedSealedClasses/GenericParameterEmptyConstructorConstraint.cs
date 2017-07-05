namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
