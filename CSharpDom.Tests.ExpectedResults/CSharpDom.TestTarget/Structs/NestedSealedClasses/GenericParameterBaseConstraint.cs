namespace CSharpDom.TestTarget.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
