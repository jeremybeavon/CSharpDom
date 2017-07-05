namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint
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
