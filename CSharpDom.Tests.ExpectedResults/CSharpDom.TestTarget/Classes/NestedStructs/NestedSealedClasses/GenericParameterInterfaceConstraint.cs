namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedClassWithGenericParameterInterfaceConstraint
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
