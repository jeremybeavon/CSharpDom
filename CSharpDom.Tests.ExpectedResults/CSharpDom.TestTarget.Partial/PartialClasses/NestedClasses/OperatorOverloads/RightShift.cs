namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedClassWithRightShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
