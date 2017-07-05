namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
