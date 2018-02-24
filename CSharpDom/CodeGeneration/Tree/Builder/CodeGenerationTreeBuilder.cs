using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Wrappers;
using System;
using SerializableClassReference = CSharpDom.Serialization.ClassReference;
using SerializableTypeReference = CSharpDom.Serialization.TypeReference;

namespace CSharpDom.CodeGeneration.Tree.Builder
{
    public sealed class CodeGenerationTreeBuilder : AbstractGenericVisitor
    {
        public CodeGenerationTreeBuilder(IVisitable<IGenericVisitor> visitable)
        {
            if (visitable != null)
            {
                visitable.Accept(this);
            }
        }

        public Expression Expression { get; private set; }

        public override void Visit(IVisitable<IGenericVisitor> node)
        {
            throw new InvalidOperationException();
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> @namespace)
        {
            Namespace properties;
            ObjectInitializerExpression expression = CreateExpression(typeof(Namespace));
            expression.CreateObjectExpression.NewExpression.Parameters.Add(CreateArgument(@namespace.Name));
            expression.Members.AddIfNotNull(nameof(properties.Classes), @namespace.Classes);
            UseExpression(expression);
        }

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            Class properties;
            ObjectInitializerExpression expression = CreateExpression(typeof(Class));
            expression.CreateObjectExpression.NewExpression.Parameters.Add(CreateArgument(@class.Name));
            expression.Members.AddIfNotNull(nameof(properties.Visibility), @class.Visibility);
            expression.Members.AddIfNotNull(nameof(properties.GenericParameters), @class.GenericParameters);
            expression.Members.AddIfNotNull(nameof(properties.BaseClass), @class.BaseClass);
            VisitClassType(@class);
            if (Expression.ObjectInitializerExpression != null)
            {
                expression.Members.Add(nameof(properties.Body), Expression);
            }

            UseExpression(expression);
        }

        public override void VisitClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            ClassBody properties;
            ObjectInitializerExpression expression = CreateExpression(typeof(ClassBody));
            expression.Members.AddIfNotNull(nameof(properties.Fields), @class.Fields);
            expression.Members.AddIfNotNull(nameof(properties.Events), @class.Events);
            expression.Members.AddIfNotNull(nameof(properties.Properties), @class.Properties);
            expression.Members.AddIfNotNull(
                nameof(properties.ExplicitInterfaceProperties),
                WrapperFactory.CreateClassPropertyCollectionWrapper(@class.Properties).ExplicitInterfaceProperties);
            expression.Members.AddIfNotNull(nameof(properties.Indexers), @class.Indexers);
            //
            expression.Members.AddIfNotNull(nameof(properties.Methods), @class.Methods);
            UseExpression(expression);
        }

        public override void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            ClassMethod properties;
            ObjectInitializerExpression expression = CreateExpression(typeof(ClassMethod));
            expression.CreateObjectExpression.NewExpression.Parameters.Add(CreateArgument(method.Name));
            expression.Members.AddIfNotNull(nameof(properties.Visibility), method.Visibility);
            expression.Members.AddIfNotNull(nameof(properties.InheritanceModifier), method.InheritanceModifier);
            expression.Members.AddIfNotNull(nameof(properties.IsAsync), method.IsAsync);
            expression.Members.AddIfNotNull(nameof(properties.ReturnType), method.ReturnType);
            expression.Members.AddIfNotNull(nameof(properties.GenericParameters), method.GenericParameters);
            expression.Members.AddIfNotNull(nameof(properties.Parameters), method.Parameters);
            UseExpression(expression);
        }

        private void UseExpression(ObjectInitializerExpression expression)
        {
            if (expression.Elements.Count == 0 &&
                expression.Initializers.Count == 0 &&
                expression.Members.Count == 0)
            {
                Expression = new Expression()
                {
                    NewExpression = expression.CreateObjectExpression.NewExpression
                };
            }
            else
            {
                Expression = new Expression()
                {
                    ObjectInitializerExpression = expression
                };
            }
        }

        internal static Argument CreateArgument(string text)
        {
            return new Argument()
            {
                Expression = CreateExpression(text)
            };
        }

        internal static Expression CreateExpression(string text)
        {
            return new Expression()
            {
                StringConstantExpression = new StringConstantExpression()
                {
                    Constant = text
                }
            };
        }

        internal static ObjectInitializerExpression CreateExpression(Type type)
        {
            return new ObjectInitializerExpression()
            {
                CreateObjectExpression = new CreateObjectExpression()
                {
                    NewExpression = new NewExpression()
                    {
                        Type = new SerializableTypeReference()
                        {
                            ClassReference = new SerializableClassReference()
                            {
                                Name = type.Name()
                            }
                        }
                    }
                }
            };
        }
    }
}
