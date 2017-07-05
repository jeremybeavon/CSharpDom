namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
