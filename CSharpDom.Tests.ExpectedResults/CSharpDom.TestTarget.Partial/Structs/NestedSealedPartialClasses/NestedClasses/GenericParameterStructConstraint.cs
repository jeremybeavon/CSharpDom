namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
