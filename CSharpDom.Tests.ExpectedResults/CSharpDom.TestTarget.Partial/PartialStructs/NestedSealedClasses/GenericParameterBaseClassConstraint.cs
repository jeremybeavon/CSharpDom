namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
