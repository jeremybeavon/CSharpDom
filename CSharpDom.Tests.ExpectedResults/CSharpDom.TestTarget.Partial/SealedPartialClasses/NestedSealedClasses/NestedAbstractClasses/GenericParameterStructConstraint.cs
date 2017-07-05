namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint
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
