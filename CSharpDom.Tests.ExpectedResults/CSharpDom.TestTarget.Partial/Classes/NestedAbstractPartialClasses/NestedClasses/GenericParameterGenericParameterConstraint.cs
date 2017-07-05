namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
