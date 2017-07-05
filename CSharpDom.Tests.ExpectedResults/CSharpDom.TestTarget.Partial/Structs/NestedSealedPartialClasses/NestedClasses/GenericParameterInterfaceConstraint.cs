namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
