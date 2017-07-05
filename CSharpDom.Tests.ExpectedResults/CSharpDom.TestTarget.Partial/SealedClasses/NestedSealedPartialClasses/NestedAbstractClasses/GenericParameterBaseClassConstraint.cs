namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
