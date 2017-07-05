namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStructs
{
    public partial class PartialClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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
