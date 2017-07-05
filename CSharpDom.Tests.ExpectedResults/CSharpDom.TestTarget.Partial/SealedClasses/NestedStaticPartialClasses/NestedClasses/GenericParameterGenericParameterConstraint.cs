namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
