namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
