namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
