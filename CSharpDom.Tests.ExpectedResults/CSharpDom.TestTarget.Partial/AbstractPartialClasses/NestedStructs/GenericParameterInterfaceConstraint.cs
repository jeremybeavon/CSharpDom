namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
