namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
