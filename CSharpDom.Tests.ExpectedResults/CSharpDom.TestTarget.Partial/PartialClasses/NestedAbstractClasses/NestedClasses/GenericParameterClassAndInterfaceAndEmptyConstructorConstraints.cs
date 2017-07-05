namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
