namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
