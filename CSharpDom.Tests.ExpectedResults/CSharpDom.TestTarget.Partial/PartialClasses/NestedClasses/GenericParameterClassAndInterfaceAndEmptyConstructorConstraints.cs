namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
