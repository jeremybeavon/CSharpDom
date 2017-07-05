namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
