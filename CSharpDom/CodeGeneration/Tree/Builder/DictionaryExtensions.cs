using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SystemEnum = System.Enum;
using Expression = CSharpDom.Serialization.Expressions.Expression;

namespace CSharpDom.CodeGeneration.Tree.Builder
{
    internal static class DictionaryExtensions
    {
        public static void AddIfNotNull(this IDictionary<string, Expression> members, string propertyName, object value)
        {
            if (value != null)
            {
                members.Add(propertyName, GetExpression(value));
            }
        }
        
        private static Expression GetExpression(object value)
        {
            if (value == null)
            {
                return null;
            }

            Expression expression;
            if (TryGetEnumerableExpression(value, out expression))
            {
                return expression;
            }

            return GetVisitableExpression(value) ??
                GetStringConstantExpression(value) ??
                GetIntegerConstantExpression(value) ??
                OnUnknownExpression();
        }

        private static bool TryGetEnumerableExpression(object value, out Expression expression)
        {
            expression = null;
            IEnumerable enumerable = value as IEnumerable;
            if (enumerable != null)
            {
                foreach (object item in enumerable)
                {
                    if (expression == null)
                    {
                        expression = new Expression()
                        {
                            ObjectInitializerExpression = CodeGenerationTreeBuilder.CreateExpression(
                                typeof(Collection<>).MakeGenericType(item.GetType()))
                        };
                    }

                    expression.ObjectInitializerExpression.Elements.Add(new List<Expression>() { GetExpression(item) });
                }
            }

            return enumerable != null;
        }

        private static Expression GetVisitableExpression(object value)
        {
            IVisitable<IGenericVisitor> visitable = value as IVisitable<IGenericVisitor>;
            return visitable == null ? null : new CodeGenerationTreeBuilder(visitable).Expression;
        }

        private static Expression GetStringConstantExpression(object value)
        {
            string text = value as string;
            return text == null ? null : CodeGenerationTreeBuilder.CreateExpression(text);
        }

        private static Expression GetEnumConstantExpression(object value)
        {
            Type type = value.GetType();
            if (type.IsEnum)
            {
                return new Expression()
                {
                    MemberExpression = new MemberExpression()
                    {
                        ObjectExpression = new Expression()
                        {
                            IdentifierExpression = new IdentifierExpression()
                            {
                                Name = type.Name
                            }
                        },
                        MemberName = SystemEnum.GetName(type, value)
                    }
                };
            }

            return null;
        }

        private static Expression GetIntegerConstantExpression(object value)
        {
            if (value is int)
            {
                return new Expression()
                {
                    IntegerConstantExpression = new IntegerConstantExpression()
                    {
                        Constant = (int)value
                    }
                };
            }

            return null;
        }

        private static Expression OnUnknownExpression()
        {
            throw new InvalidOperationException();
        }
    }
}
