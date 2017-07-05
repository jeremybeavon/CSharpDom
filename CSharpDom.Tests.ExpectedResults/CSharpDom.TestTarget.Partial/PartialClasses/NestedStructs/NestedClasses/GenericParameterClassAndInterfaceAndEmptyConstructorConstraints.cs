namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedClasses
{
    public partial class PartialClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
