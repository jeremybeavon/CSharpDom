namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStructs
{
    public partial class PartialClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
