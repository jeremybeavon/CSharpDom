using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Serialization;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Statements;

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
                RewriteMethodBody(hasBody.Body, hasReturnType.ReturnType);
            }
        }

        public override void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            RewriteMethodBody(accessor.Body as MethodBody, accessorReturnType);
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            if (property.GetAccessor != null)
            {
                accessorReturnType = property.PropertyType as TypeReference;
                property.GetAccessor.Accept(this);
            }

            if (property.SetAccessor != null)
            {
                accessorReturnType = new TypeReference()
                {
                    BuiltInTypeReference = new BuiltInTypeReference()
                    {
                        Type = BuiltInType.Void
                    }
                };
                property.SetAccessor.Accept(this);
            }
        }

        private static void RewriteMethodBody(MethodBody body, TypeReference returnType)
        {
            body.Instructions.Clear();
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
    }
}
