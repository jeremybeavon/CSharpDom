namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
