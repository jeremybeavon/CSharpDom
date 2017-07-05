namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
