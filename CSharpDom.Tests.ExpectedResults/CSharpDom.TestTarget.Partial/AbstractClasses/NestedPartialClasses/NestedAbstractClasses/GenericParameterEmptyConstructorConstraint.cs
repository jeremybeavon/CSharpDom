namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
