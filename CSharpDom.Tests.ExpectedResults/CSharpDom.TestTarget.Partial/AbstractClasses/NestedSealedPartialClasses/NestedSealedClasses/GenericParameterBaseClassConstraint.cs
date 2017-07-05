namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
