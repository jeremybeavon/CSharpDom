namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
