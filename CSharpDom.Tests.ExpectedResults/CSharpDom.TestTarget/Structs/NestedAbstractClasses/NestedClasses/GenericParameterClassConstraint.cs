namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses
{
    public struct StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
