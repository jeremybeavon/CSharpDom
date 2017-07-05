namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
