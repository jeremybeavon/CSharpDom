namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraint
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
