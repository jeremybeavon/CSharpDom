namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
