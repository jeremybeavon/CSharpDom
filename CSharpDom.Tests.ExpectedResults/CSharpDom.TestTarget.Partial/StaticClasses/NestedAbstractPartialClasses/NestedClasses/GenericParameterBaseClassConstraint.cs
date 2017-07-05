namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
