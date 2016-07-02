namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
