namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
