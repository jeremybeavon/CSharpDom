namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
