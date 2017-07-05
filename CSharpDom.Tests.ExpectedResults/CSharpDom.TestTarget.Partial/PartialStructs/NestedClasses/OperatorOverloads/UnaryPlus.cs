namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedClassWithUnaryPlusOperatorOverload
    {
        public class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
