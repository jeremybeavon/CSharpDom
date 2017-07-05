namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStaticClasses
{
    public partial class PartialClassWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
