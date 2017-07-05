namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedClasses
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
