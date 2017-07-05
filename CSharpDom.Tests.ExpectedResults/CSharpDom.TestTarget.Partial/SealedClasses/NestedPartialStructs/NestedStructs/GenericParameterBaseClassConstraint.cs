namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
