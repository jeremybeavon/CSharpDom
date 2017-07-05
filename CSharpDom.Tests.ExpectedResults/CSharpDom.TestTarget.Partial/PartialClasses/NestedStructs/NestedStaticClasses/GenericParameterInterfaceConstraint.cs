namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStaticClasses
{
    public partial class PartialClassWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
