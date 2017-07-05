namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
