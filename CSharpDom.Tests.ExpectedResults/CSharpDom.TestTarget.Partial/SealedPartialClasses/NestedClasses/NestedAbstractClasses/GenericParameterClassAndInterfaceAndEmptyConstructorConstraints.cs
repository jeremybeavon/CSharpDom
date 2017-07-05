namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
