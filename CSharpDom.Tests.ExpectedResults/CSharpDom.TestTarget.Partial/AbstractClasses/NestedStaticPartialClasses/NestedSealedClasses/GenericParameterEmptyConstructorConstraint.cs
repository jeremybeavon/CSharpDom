namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
