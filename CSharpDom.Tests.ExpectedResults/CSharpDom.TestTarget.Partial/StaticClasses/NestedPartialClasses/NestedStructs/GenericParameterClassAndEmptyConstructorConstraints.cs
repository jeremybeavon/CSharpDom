namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
