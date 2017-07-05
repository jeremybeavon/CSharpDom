namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
