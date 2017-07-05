namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStructs
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
