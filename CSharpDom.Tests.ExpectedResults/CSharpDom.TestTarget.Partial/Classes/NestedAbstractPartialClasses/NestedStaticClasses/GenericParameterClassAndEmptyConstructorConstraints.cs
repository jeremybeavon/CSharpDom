namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
