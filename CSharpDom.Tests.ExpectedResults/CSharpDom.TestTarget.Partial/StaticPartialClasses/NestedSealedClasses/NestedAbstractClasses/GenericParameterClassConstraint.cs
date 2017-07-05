namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
