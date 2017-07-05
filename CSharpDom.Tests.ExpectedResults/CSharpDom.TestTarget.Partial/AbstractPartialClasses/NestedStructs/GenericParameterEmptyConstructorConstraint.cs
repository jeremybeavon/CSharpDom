namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
