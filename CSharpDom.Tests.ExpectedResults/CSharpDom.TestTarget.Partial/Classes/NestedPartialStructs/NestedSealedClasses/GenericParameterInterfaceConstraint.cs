namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
