namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
