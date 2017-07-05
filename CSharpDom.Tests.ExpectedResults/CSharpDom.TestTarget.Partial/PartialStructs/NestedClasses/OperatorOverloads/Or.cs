namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedClassWithOrOperatorOverload
    {
        public class Class
        {
            public static Class operator |(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
