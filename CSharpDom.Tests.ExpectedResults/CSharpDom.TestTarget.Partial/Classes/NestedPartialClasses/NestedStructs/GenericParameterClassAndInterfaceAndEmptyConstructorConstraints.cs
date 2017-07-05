namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStructs
{
    public class ClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
