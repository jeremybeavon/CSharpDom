namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStructs
{
    public partial class PartialClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
