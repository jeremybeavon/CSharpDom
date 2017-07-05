namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
