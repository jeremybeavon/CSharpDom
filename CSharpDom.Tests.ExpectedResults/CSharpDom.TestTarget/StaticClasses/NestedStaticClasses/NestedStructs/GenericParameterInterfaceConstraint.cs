namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
