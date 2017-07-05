namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
