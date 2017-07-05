namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
