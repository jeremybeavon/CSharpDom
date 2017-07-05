namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
