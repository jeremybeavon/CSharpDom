using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public class SourceCodeExpressionBuilder : ExpressionVisitor
    {
        private readonly SourceCodeTextBuilder textBuilder;

        public SourceCodeExpressionBuilder(SourceCodeTextBuilder textBuilder)
        {
            this.textBuilder = textBuilder;
        }

        public static string ToString(ExpressionType expressionType)
        {
            switch (expressionType)
            {
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                    return " + ";
                case ExpressionType.AddAssign:
                case ExpressionType.AddAssignChecked:
                    return " += ";
                case ExpressionType.And:
                    return " & ";
                case ExpressionType.AndAlso:
                    return " && ";
                case ExpressionType.AndAssign:
                    return " &= ";
                case ExpressionType.Assign:
                    return " = ";
                case ExpressionType.Coalesce:
                    return " ?? ";
                case ExpressionType.Decrement:
                    return "++";
                case ExpressionType.Divide:
                    return " / ";
                case ExpressionType.DivideAssign:
                    return " /= ";
                case ExpressionType.Equal:
                    return " == ";
                case ExpressionType.ExclusiveOr:
                    return " ^ ";
                case ExpressionType.ExclusiveOrAssign:
                    return " ^= ";
                case ExpressionType.GreaterThan:
                    return " > ";
                case ExpressionType.GreaterThanOrEqual:
                    return " >= ";
                case ExpressionType.Increment:
                    return "++";
                case ExpressionType.LeftShift:
                    return " << ";
                case ExpressionType.LeftShiftAssign:
                    return " <<= ";
                case ExpressionType.LessThan:
                    return " < ";
                case ExpressionType.LessThanOrEqual:
                    return " <= ";
                case ExpressionType.Modulo:
                    return " % ";
                case ExpressionType.ModuloAssign:
                    return " %= ";
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                    return " * ";
                case ExpressionType.MultiplyAssign:
                case ExpressionType.MultiplyAssignChecked:
                    return " *= ";
                case ExpressionType.Negate:
                case ExpressionType.NegateChecked:
                    return "-";
                case ExpressionType.Not:
                    return "!";
                case ExpressionType.NotEqual:
                    return " != ";
                case ExpressionType.OnesComplement:
                    return "~";
                case ExpressionType.Or:
                    return " | ";
                case ExpressionType.OrAssign:
                    return " |= ";
                case ExpressionType.OrElse:
                    return " || ";
                case ExpressionType.PostDecrementAssign:
                    return "--";
                case ExpressionType.PostIncrementAssign:
                    return "++";
                case ExpressionType.PreDecrementAssign:
                    return "--";
                case ExpressionType.PreIncrementAssign:
                    return "++";
                case ExpressionType.RightShift:
                    return " >> ";
                case ExpressionType.RightShiftAssign:
                    return " >>= ";
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                    return " - ";
                case ExpressionType.SubtractAssign:
                case ExpressionType.SubtractAssignChecked:
                    return " -= ";
                case ExpressionType.TypeAs:
                    return " as ";
                case ExpressionType.TypeIs:
                    return " is ";
                case ExpressionType.UnaryPlus:
                    return "+";
                default:
                    throw new NotSupportedException();
            }
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Visit(node.Left);
            Append(ToString(node.NodeType));
            Visit(node.Right);
            return node;
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            AppendBlock(() => Visit(node.Expressions));
            return node;
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            return base.VisitCatchBlock(node);
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            Visit(node.Test);
            Append(" ? ");
            Visit(node.IfTrue);
            Append(" : ");
            Visit(node.IfFalse);
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            Append(node.Value.ToString());
            return node;
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            Append("default(");
            Append(node.Type);
            Append(")");
            return node;
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            throw new NotSupportedException();
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            if (node.Arguments.Count > 1)
            {
                Append("{ ");
            }

            AppendCommaSeparatedExpressions(node.Arguments);
            if (node.Arguments.Count > 1)
            {
                Append(" }");
            }

            return node;
        }

        protected override Expression VisitExtension(Expression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            Visit(node.Object);
            Append("[");
            AppendCommaSeparatedExpressions(node.Arguments);
            Append("]");
            return node;
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            Visit(node.Expression);
            Append("(");
            AppendCommaSeparatedExpressions(node.Arguments);
            Append(")");
            return node;
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            throw new NotSupportedException();
        }

        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            if (node.Parameters.Count > 1)
            {
                Append("(");
            }

            AppendCommaSeparatedExpressions(node.Parameters);
            if (node.Parameters.Count > 1)
            {
                Append(")");
            }

            Append(" => ");
            Visit(node.Body);
            return node;
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            Visit(node.NewExpression);
            AppendIndentedCommaSeparatedBlock(node.Initializers, VisitElementInit);
            return node;
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            Visit(node.Expression);
            Append(".");
            Append(node.Member);
            return node;
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            Append(node.Member);
            Append(" = ");
            Visit(node.Expression);
            return node;
        }
        
        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            Visit(node.NewExpression);
            AppendIndentedCommaSeparatedBlock(node.Bindings, VisitMemberBinding);
            return node;
        }

        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            Append(node.Member);
            Append(" = ");
            AppendIndentedCommaSeparatedBlock(node.Initializers, VisitElementInit);
            return node;
        }

        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            Append(node.Member);
            Append(" = ");
            AppendIndentedCommaSeparatedBlock(node.Bindings, VisitMemberBinding);
            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            Visit(node.Object);
            Append(".");
            Append(node.Method);
            Append("(");
            AppendCommaSeparatedExpressions(node.Arguments);
            Append(")");
            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            Append("new ");
            Append(node.Constructor.DeclaringType);
            Append("(");
            Visit(node.Arguments);
            Append(")");
            return node;
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            Append("new ");
            Append(node.Type);
            Visit(node.Expressions);
            return node;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            Append(node.Name);
            return node;
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            throw new NotSupportedException();
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            Visit(node.Expression);
            Append(ToString(node.NodeType));
            Append(node.TypeOperand);
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            bool isPostfix = 
                node.NodeType == ExpressionType.PostDecrementAssign ||
                node.NodeType == ExpressionType.PostIncrementAssign;
            if (!isPostfix)
            {
                Append(ToString(node.NodeType));
            }

            Visit(node.Operand);
            if (isPostfix)
            {
                Append(ToString(node.NodeType));
            }

            return node;
        }

        protected void Append(string text)
        {
            textBuilder.Append(text);
        }

        protected void Append(Type type)
        {
            Append(type.Name);
        }

        protected void Append(MemberInfo member)
        {
            Append(member.Name);
        }

        protected void AppendWithIndent(string text)
        {
            textBuilder.AppendWithIndent(text);
        }

        protected void AppendBlock(Action action)
        {
            textBuilder.AppendWithIndent("{");
            using (textBuilder.IncrementIndent())
            {
                action();
            }

            textBuilder.AppendWithIndent("}");
        }

        protected void AppendCommaSeparatedExpressions(IEnumerable<Expression> expressions)
        {
            if (expressions == null)
            {
                return;
            }

            string comma = string.Empty;
            foreach (Expression expression in expressions)
            {
                Append(comma);
                Visit(expression);
                comma = ", ";
            }
        }

        private void AppendIndentedCommaSeparatedBlock<T>(IEnumerable<T> expressions, Func<T, T> action)
        {
            Action blockAction = () =>
            {
                string comma = string.Empty;
                foreach (T expression in expressions)
                {
                    AppendWithIndent(comma);
                    action(expression);
                    comma = ",";
                }
            };
            AppendBlock(blockAction);
        }
    }
}
