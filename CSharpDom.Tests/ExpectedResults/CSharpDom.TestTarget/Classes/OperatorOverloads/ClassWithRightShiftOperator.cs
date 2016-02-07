namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithRightShiftOperator
    {
        public static ClassWithRightShiftOperator operator >>(ClassWithRightShiftOperator parameter1, int parameter2)
        {
            return parameter1;
        }
    }
}
