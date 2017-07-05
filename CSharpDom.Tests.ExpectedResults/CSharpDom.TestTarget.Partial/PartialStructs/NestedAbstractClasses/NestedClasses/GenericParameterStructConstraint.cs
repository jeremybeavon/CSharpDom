namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
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
