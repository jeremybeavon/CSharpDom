namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
