namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
