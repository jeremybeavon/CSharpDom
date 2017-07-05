namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
