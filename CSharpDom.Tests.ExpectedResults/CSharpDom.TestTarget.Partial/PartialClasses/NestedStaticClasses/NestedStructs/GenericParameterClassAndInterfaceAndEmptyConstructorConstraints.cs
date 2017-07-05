namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStructs
{
    public partial class PartialClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
