namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
