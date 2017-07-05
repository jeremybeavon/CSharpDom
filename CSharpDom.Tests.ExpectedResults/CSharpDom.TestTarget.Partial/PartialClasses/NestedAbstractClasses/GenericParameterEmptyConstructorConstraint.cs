namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
