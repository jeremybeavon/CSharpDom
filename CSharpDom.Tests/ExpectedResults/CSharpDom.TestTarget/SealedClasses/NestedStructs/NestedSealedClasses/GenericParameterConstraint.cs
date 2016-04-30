namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
