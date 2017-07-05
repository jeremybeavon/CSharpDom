namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedSealedClasses
{
    public partial class PartialClassWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraint
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
