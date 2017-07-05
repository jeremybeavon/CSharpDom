namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint
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
