namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStructs
{
    public static class StaticClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint
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
