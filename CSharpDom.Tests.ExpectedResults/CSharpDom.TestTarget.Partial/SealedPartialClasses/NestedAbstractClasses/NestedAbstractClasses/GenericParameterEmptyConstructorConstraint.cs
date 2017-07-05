namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
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
