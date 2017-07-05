namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
