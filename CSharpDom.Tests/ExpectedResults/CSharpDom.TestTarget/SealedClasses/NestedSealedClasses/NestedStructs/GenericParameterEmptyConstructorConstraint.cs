namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
