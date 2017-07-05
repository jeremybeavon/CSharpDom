namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
