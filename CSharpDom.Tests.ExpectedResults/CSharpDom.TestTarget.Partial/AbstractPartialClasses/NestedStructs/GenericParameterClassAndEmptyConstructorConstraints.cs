namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
