namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedClassWithGenericParameterClassConstraint
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
