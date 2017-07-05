namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
