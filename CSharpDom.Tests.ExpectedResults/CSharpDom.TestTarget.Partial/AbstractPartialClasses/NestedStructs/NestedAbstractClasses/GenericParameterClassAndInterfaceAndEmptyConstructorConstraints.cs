namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
