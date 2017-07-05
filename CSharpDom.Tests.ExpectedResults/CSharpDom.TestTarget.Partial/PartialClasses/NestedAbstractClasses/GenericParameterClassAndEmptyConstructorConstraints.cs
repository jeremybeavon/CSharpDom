namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
