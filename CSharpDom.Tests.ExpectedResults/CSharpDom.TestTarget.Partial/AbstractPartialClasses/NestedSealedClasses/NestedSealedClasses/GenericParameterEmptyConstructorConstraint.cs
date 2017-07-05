namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
