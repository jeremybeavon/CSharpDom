namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
