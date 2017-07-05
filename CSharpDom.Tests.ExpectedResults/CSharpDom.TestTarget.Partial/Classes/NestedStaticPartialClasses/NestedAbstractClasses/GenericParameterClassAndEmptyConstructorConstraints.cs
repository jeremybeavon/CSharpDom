namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
