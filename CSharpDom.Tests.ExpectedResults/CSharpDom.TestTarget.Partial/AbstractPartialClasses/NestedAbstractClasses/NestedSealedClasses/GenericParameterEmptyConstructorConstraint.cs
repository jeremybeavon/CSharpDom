namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
