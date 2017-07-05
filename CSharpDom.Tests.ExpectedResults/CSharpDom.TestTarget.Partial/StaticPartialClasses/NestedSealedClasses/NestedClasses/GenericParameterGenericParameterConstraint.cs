namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
