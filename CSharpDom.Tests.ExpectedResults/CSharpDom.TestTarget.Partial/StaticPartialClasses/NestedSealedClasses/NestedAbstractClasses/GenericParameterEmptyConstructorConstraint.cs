namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
