namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
