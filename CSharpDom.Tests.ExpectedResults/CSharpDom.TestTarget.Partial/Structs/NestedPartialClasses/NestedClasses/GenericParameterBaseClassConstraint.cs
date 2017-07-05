namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedClasses
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
