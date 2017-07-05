namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
