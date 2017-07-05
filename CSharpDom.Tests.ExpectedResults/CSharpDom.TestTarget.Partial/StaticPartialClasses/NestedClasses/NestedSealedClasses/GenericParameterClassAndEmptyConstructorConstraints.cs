namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
