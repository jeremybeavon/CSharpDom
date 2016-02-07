namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithPlusOperator
    {
        public static ClassWithPlusOperator operator +(ClassWithPlusOperator parameter1, ClassWithPlusOperator parameter2)
        {
            return default(ClassWithPlusOperator);
        }
    }
}
