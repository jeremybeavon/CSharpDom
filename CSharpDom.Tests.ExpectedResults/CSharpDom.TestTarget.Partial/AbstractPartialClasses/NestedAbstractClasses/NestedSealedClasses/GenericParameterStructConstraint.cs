namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
