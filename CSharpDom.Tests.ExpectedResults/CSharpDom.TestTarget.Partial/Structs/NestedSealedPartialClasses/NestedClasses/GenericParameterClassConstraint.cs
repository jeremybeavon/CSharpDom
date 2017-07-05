namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
