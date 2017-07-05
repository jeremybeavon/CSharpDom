namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
