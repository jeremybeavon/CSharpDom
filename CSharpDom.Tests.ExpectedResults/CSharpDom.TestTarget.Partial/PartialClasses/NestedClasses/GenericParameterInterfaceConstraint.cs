namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
