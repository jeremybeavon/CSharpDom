namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
