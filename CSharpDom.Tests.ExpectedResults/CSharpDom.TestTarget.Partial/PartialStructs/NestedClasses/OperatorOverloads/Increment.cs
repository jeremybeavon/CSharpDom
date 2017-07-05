namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedClassWithIncrementOperatorOverload
    {
        public class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
