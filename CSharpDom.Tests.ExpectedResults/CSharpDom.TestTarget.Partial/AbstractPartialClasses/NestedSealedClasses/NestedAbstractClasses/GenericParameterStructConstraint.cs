namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
