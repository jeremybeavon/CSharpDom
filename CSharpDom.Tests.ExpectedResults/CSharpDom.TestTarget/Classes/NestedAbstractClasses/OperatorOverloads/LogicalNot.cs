namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractClassWithLogicalNotOperatorOverload
    {
        public abstract class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
