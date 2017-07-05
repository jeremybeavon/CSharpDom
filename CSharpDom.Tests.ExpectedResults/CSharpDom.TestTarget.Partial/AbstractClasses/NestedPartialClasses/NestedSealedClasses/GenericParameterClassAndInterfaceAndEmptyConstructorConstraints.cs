namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
