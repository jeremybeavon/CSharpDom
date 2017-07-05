namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedClasses
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
