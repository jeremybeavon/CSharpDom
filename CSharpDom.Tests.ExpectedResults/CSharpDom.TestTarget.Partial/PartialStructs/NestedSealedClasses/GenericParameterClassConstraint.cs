namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
