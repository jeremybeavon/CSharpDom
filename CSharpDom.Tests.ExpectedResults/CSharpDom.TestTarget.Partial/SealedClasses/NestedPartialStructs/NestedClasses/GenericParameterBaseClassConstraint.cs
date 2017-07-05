namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
