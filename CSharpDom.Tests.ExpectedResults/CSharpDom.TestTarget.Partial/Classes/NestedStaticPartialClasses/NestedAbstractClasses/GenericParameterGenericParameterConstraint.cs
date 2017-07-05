namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedAbstractClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
