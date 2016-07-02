namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
