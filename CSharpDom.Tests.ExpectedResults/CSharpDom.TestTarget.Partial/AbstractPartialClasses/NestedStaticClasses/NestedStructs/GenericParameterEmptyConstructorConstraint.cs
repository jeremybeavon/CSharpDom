namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
