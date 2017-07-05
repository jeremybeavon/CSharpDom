namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
