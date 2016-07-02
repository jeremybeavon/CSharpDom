namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedClassWithLogicalNotOperatorOverload
    {
        public class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
