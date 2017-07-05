namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint
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
