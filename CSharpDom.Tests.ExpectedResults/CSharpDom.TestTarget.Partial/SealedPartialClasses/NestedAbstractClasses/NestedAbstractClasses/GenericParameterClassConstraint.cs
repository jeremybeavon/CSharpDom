namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
