namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedAbstractClassWithBitwiseNotOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator ~(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
