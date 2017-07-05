namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
