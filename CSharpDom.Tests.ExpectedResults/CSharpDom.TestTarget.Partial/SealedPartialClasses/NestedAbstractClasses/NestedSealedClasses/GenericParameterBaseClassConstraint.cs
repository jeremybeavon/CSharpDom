namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
