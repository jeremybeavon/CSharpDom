namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedSealedClasses
{
    public partial class PartialClassWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
