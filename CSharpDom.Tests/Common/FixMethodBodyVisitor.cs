using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Serialization;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Statements;
using System.Linq;

namespace CSharpDom.Tests.Common
{
    internal sealed class FixMethodBodyVisitor : AbstractGenericVisitor
    {
        private TypeReference accessorReturnType;

        public override void Visit(IVisitable<IGenericVisitor> node)
        {
            IHasBody<MethodBody> hasBody = node as IHasBody<MethodBody>;
            IHasReturnType<TypeReference> hasReturnType = node as IHasReturnType<TypeReference>;
            if (hasBody == null || hasReturnType == null)
            {
                base.Visit(node);
            }
            else
            {
                RewriteMethodBody(hasBody.Body, hasReturnType.ReturnType, node as IHasParameters<MethodParameter>);
            }
        }

        public override void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            RewriteMethodBody(accessor.Body as MethodBody, accessorReturnType);
        }

        public override void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            RewriteMethodBody(constructor.Body as MethodBody, constructor as IHasParameters<ConstructorParameter>);
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            RewriteMethodBody(conversionOperator.Body as MethodBody, conversionOperator.ReturnType as TypeReference);
        }

        public override void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
        {
            VisitPropertyOrIndexer(indexer, indexer.IndexerType);
        }

        public override void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
        {
            VisitPropertyOrIndexer(property, property.PropertyType);
        }

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            VisitPropertyOrIndexer(indexer, indexer.IndexerType);
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            RewriteMethodBody(operatorOverload.Body as MethodBody, operatorOverload.ReturnType as TypeReference);
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            VisitPropertyOrIndexer(property, property.PropertyType);
        }

        private static void RewriteMethodBody(MethodBody body, TypeReference returnType)
        {
            if (returnType.BuiltInTypeReference == null || returnType.BuiltInTypeReference.Type != BuiltInType.Void)
            {
                Statement statement = new Statement()
                {
                    ReturnStatement = new ReturnStatement()
                    {
                        Expression = new Expression()
                        {
                            DefaultExpression = new DefaultExpression()
                            {
                                Type = returnType
                            }
                        }
                    }
                };
                body.Statements.Add(statement);
            }
        }

        private static void RewriteMethodBody<TParameter>(MethodBody body, TypeReference returnType, IHasParameters<TParameter> parameters)
            where TParameter : IParameter<AttributeGroup, TypeReference>, IHasModifier<ParameterModifier>
        {
            RewriteMethodBody(body, parameters);
            RewriteMethodBody(body, returnType);
        }

        private static void RewriteMethodBody<TParameter>(MethodBody body, IHasParameters<TParameter> parameters)
            where TParameter : IParameter<AttributeGroup, TypeReference>, IHasModifier<ParameterModifier>
        {
            body.Instructions.Clear();
            if (parameters != null)
            {
                foreach (TParameter parameter in parameters.Parameters)
                {
                    if (parameter.Modifier == ParameterModifier.Out)
                    {
                        Statement statement = new Statement()
                        {
                            ExpressionStatement = new ExpressionStatement()
                            {
                                Expression = CreateExpressionForOutParameter(parameter)
                            }
                        };
                        body.Statements.Add(statement);
                    }
                }
            }
        }

        private static Expression CreateExpressionForOutParameter(IParameter<AttributeGroup, TypeReference> parameter)
        {
            return new Expression()
            {
                BinaryOperatorExpression = new BinaryOperatorExpression()
                {
                    Left = new Expression()
                    {
                        IdentifierExpression = new IdentifierExpression()
                        {
                            Name = parameter.Name
                        }
                    },
                    OperatorType = BinaryOperatorExpressionType.Assign,
                    Right = new Expression()
                    {
                        DefaultExpression = new DefaultExpression()
                        {
                            Type = parameter.ParameterType
                        }
                    }
                }
            };
        }

        private void VisitPropertyOrIndexer<TAccessor, TTypeReference>(
            IHasAccessors<TAccessor> propertyOrIndexer,
            TTypeReference type)
            where TAccessor : IAccessor
        {
            if (propertyOrIndexer.GetAccessor != null)
            {
                accessorReturnType = type as TypeReference;
                propertyOrIndexer.GetAccessor.Accept(this);
            }

            if (propertyOrIndexer.SetAccessor != null)
            {
                accessorReturnType = new TypeReference()
                {
                    BuiltInTypeReference = new BuiltInTypeReference()
                    {
                        Type = BuiltInType.Void
                    }
                };
                propertyOrIndexer.SetAccessor.Accept(this);
            }
        }
    }
}
