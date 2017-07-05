namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStructs
{
    public partial class PartialClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
