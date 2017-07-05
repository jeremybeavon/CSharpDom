namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
