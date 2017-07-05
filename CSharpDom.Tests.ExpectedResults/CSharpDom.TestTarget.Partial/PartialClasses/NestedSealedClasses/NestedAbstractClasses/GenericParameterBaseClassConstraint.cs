namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
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
