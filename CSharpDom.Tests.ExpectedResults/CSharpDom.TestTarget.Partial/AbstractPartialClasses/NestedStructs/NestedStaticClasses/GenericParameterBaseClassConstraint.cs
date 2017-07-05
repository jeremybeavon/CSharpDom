namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraint
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
