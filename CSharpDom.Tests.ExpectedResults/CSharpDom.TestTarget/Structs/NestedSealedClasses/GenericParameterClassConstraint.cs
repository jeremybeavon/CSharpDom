namespace CSharpDom.TestTarget.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
