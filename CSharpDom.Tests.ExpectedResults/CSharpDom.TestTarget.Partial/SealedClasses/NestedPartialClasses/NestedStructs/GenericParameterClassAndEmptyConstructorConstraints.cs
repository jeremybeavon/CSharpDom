namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
