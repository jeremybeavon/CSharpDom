namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithLeftShiftOperator
    {
        public static ClassWithLeftShiftOperator operator <<(ClassWithLeftShiftOperator parameter1, int parameter2)
        {
            return parameter1;
        }
    }
}
