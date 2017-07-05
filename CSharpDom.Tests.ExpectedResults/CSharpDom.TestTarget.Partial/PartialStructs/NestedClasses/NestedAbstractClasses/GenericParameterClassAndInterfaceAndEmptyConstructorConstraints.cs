namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
