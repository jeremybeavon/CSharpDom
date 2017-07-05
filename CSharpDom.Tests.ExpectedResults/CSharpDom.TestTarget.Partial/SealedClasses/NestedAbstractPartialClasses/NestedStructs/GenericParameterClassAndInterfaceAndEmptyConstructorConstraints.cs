namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
