namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
