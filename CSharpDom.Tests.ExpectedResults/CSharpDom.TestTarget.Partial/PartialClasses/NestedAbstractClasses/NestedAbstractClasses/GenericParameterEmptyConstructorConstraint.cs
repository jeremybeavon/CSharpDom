namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
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
