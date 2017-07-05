namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
