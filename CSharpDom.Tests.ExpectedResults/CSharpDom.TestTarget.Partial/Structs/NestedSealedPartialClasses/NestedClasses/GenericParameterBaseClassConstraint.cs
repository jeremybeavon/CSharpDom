namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
