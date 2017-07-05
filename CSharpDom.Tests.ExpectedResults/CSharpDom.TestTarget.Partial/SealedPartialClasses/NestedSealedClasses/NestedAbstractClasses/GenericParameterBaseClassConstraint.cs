namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
