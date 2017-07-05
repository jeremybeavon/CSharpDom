namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
