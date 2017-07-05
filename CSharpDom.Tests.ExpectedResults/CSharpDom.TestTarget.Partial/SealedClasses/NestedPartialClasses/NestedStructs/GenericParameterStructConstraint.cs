namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
