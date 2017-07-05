namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedClasses
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
