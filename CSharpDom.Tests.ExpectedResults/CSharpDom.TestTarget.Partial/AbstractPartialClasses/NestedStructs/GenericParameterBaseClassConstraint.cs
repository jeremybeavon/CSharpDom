namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct<T>
            where T : BaseClass
        {
        }
    }
}
