namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedClassWithLeftShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
