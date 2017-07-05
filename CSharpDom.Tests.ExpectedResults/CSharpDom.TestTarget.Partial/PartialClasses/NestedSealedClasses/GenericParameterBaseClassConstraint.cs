namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
