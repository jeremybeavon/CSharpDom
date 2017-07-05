namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
