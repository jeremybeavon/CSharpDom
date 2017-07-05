namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
