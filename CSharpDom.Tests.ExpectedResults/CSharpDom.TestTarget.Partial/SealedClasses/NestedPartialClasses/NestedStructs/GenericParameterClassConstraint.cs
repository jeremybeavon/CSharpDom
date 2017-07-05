namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
