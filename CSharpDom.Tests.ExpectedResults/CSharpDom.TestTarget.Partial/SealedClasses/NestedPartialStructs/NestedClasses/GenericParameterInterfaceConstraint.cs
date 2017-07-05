namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
