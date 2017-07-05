namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
