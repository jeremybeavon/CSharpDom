namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
