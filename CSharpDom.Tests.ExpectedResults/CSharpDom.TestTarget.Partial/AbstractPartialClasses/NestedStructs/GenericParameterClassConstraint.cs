namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
