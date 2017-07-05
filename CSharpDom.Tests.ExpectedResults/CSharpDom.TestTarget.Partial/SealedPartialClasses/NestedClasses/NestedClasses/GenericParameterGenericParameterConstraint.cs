namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
