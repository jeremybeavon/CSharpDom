namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
