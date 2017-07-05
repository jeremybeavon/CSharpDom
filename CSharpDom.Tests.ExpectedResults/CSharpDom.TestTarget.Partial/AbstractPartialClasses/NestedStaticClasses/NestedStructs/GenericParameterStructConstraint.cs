namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
