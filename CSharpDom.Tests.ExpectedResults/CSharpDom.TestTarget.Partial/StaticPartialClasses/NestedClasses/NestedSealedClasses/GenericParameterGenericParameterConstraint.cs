namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
