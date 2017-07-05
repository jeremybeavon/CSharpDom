namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
