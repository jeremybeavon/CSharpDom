namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
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
