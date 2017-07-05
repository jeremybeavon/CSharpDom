namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
