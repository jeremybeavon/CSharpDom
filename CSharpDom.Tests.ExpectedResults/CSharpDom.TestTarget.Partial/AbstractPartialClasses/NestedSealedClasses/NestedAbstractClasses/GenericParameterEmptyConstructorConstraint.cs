namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
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
