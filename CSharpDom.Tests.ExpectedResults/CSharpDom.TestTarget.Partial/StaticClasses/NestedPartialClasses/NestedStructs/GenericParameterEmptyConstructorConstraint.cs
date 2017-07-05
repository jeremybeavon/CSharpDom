namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
