namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
