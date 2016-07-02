namespace CSharpDom.TestTarget.Structs.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
