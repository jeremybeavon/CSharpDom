namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
