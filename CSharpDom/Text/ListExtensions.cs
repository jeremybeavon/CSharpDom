﻿using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using CSharpDom.Text.Steps;
using CSharpDom.Text.Steps.Expressions;
using CSharpDom.Text.Steps.Statements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Text
{
    public static class ListExtensions
    {
        public static IEnumerable<ChildSteps> GetChildSteps(this List<ISourceCodeBuilderStep> steps)
        {
            foreach (ISourceCodeBuilderStep step in steps)
            {
                IHasSourceSourceBuilderSteps hasChildSteps = step as IHasSourceSourceBuilderSteps;
                IHasChildNode hasChildNode = step as IHasChildNode;
                IHasStatement hasStatement = step as IHasStatement;
                IHasExpression hasExpression = step as IHasExpression;
                if (hasChildNode != null)
                {
                    yield return new ChildSteps(hasChildNode.ChildNode, hasChildNode.Steps);
                }
                else if (hasStatement != null)
                {
                    yield return new ChildSteps(hasStatement.Statement, hasStatement.Steps);
                }
                else if (hasExpression != null)
                {
                    yield return new ChildSteps(hasExpression.Expression, hasExpression.Steps);
                }

                if (hasChildSteps != null)
                {
                    foreach (ChildSteps childSteps in hasChildSteps.Steps.GetChildSteps())
                    {
                        yield return childSteps;
                    }
                }
            }
        }

        public static IEnumerable<ChildSteps> GetChildSteps(this List<ISourceCodeBuilderStep> steps, params Type[] types)
        {
            return steps.GetChildSteps().Where(step => types.Any(type => type.IsAssignableFrom(step.Object.GetType())));
        }

        public static int? FindNextIndex(this List<ISourceCodeBuilderStep> steps, Type initialStepType, Type stepType)
        {
            int? initialIndex = steps.FindIndex(initialStepType);
            if (initialStepType == null)
            {
                return null;
            }

            return AsNullable(steps.FindIndex(initialIndex.Value + 1, GetTypePredicate(stepType)));
        }

        public static int? FindPreviousIndex(this List<ISourceCodeBuilderStep> steps, Type initialStepType, Type stepType)
        {
            int? initialIndex = steps.FindLastIndex(initialStepType);
            return AsNullable(steps.FindLastIndex(0, initialIndex.Value - 1, GetTypePredicate(stepType)));
        }

        public static int? FindIndex(this List<ISourceCodeBuilderStep> steps, Type type)
        {
            return AsNullable(steps.FindIndex(GetTypePredicate(type)));
        }

        public static int? FindLastIndex(this List<ISourceCodeBuilderStep> steps, Type type)
        {
            return AsNullable(steps.FindLastIndex(GetTypePredicate(type)));
        }

        public static void InsertAfter(this List<ISourceCodeBuilderStep> steps, Type type, ISourceCodeBuilderStep step)
        {
            int? index = steps.FindLastIndex(type);
            if (index.HasValue)
            {
                steps.Insert(index.Value + 1, step);
            }
        }

        public static void InsertBefore(this List<ISourceCodeBuilderStep> steps, Type type, ISourceCodeBuilderStep step)
        {
            int? index = steps.FindIndex(type);
            if (index.HasValue)
            {
                steps.Insert(index.Value, step);
            }
        }

        public static void RemovePrevious(this List<ISourceCodeBuilderStep> steps, Type initialStepType, Type stepType)
        {
            steps.RemoveAt(steps.FindPreviousIndex(initialStepType, stepType));
        }

        public static void RemoveNext(this List<ISourceCodeBuilderStep> steps, Type initialStepType, Type stepType)
        {
            steps.RemoveAt(steps.FindNextIndex(initialStepType, stepType));
        }

        public static void RemoveAt(this List<ISourceCodeBuilderStep> steps, int? index)
        {
            if (index.HasValue)
            {
                steps.RemoveAt(index.Value);
            }
        }

        internal static string ToSourceCode(this List<ISourceCodeBuilderStep> steps, params ISourceCodeStyleRule[] styleRules)
        {
            foreach (ISourceCodeStyleRule styleRule in styleRules.Where(rule => !rule.IsRuleAlreadyApplied))
            {
                styleRule.ApplyRule(steps);
            }

            SourceCodeTextBuilder textBuilder = new SourceCodeTextBuilder();
            foreach (ISourceCodeBuilderStep step in steps)
            {
                step.AddText(textBuilder);
            }

            return textBuilder.ToString();
        }

        internal static void AddRange(this List<ISourceCodeBuilderStep> steps, params ISourceCodeBuilderStep[] stepsToAdd)
        {
            steps.AddRange(stepsToAdd);
        }

        internal static void AddCommaSeparatedRange(this List<ISourceCodeBuilderStep> steps, params ISourceCodeBuilderStep[] stepsToAdd)
        {
            steps.AddRange(stepsToAdd, () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
        }

        internal static void AddRange(
            this List<ISourceCodeBuilderStep> steps,
            IEnumerable<ISourceCodeBuilderStep> stepsToAdd,
            Action joinFunction)
        {
            JoinList(stepsToAdd, step => steps.Add(step), joinFunction);
        }
        
        internal static void AddChildNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes,
            Action joinFunction)
            where T : IVisitable<IGenericVisitor>
        {
            JoinList(childNodes, childNode => steps.Add(new WriteChildNode<T>(childNode)), joinFunction);
        }

        internal static void AddChildNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes)
            where T : IVisitable<IGenericVisitor>
        {
            steps.AddChildNodeSteps(childNodes, () => { });
        }

        internal static void AddCommaSeparatedChildNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes)
            where T : IVisitable<IGenericVisitor>
        {
            steps.AddChildNodeSteps(childNodes, () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
        }

        internal static void AddCommaSeparatedExpressionSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> expressions)
            where T : IVisitable<IGenericExpressionVisitor>
        {
            JoinList(
                expressions,
                expression => steps.Add(new WriteExpression<T>(expression)),
                () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
        }

        internal static void AddChildNodeStepsOnNewLines<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes,
            NewLineLocation location = NewLineLocation.AfterNode)
            where T : IVisitable<IGenericVisitor>
        {
            foreach (T childNode in childNodes)
            {
                if (location == NewLineLocation.BeforeNode)
                {
                    steps.Add(new WriteIndentedNewLine());
                }

                steps.Add(new WriteChildNode<T>(childNode));
                if (location == NewLineLocation.AfterNode)
                {
                    steps.Add(new WriteIndentedNewLine());
                }
            }
        }

        internal static void AddTypeVisibilityModifierSteps(this List<ISourceCodeBuilderStep> steps, TypeVisibilityModifier visibility)
        {
            if (visibility != TypeVisibilityModifier.None)
            {
                steps.Add(new WriteTypeVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }
        
        internal static void AddPartialSteps(this List<ISourceCodeBuilderStep> steps, bool isPartial)
        {
            if (isPartial)
            {
                steps.Add(new WritePartialKeyword());
                steps.Add(new WriteWhitespace());
            }
        }

        internal static void AddGenericParameterSteps<TGenericParameter>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyList<TGenericParameter> genericParameters)
        {
            if (genericParameters.Count != 0)
            {
                steps.Add(new WriteStartGenericParameters());
                steps.AddRange(
                    genericParameters.Select(parameter => new WriteName(((IHasName)parameter).Name)),
                    () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
                steps.Add(new WriteEndGenericParameters());
            }
        }

        internal static void AddBaseClassAndImplementedInterfacesSteps<TClassReference, TInterfaceReference>(
            this List<ISourceCodeBuilderStep> steps,
            IHasBaseClass<TClassReference> baseClassContainer,
            IHasImplementedInterfaces<TInterfaceReference> implementedInterfaces)
            where TClassReference : IVisitable<IGenericVisitor>
            where TInterfaceReference : IVisitable<IGenericVisitor>
        {
            if (baseClassContainer.BaseClass != null)
            {
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteColon());
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteChildNode<TClassReference>(baseClassContainer.BaseClass));
            }

            if (implementedInterfaces.ImplementedInterfaces.Count != 0)
            {
                if (baseClassContainer.BaseClass == null)
                {
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteColon());
                    steps.Add(new WriteWhitespace());
                }
                else
                {
                    steps.Add(new WriteComma());
                    steps.Add(new WriteWhitespace());
                }
                               
                steps.AddCommaSeparatedChildNodeSteps(implementedInterfaces.ImplementedInterfaces);
            }
        }

        internal static void AddImplementedInterfacesSteps<TInterfaceReference>(
            this List<ISourceCodeBuilderStep> steps,
            IHasImplementedInterfaces<TInterfaceReference> implementedInterfaces)
            where TInterfaceReference : IVisitable<IGenericVisitor>
        {
            if (implementedInterfaces.ImplementedInterfaces.Count != 0)
            {
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteColon());
                steps.Add(new WriteWhitespace());
                steps.AddCommaSeparatedChildNodeSteps(implementedInterfaces.ImplementedInterfaces);
            }
        }

        internal static void AddGenericParameterConstraintSteps<TGenericParameter>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<TGenericParameter> genericParameters)
            where TGenericParameter : IVisitable<IGenericVisitor>
        {
            if (genericParameters.Count != 0)
            {
                steps.Add(new IncrementIndent());
                steps.AddChildNodeSteps(genericParameters);
                steps.Add(new DecrementIndent());
            }
        }

        internal static void AddInterfaceBodySteps<TEvent, TProperty, TIndexer, TMethod>(
            this List<ISourceCodeBuilderStep> steps,
            IBasicType<TEvent, TProperty, TIndexer, TMethod> type)
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Func<SourceCodeStepsBuilder> builderFactory = () => new SourceCodeStepsBuilder();
            IEnumerable<ISourceCodeBuilderStep> typeSteps =
                type.Events.Select(@event => (ISourceCodeBuilderStep)new WriteChildNode<TEvent>(@event, builderFactory()))
                .Concat(type.Properties.Select(property => new WriteChildNode<TProperty>(property, builderFactory())))
                .Concat(type.Indexers.Select(indexer => new WriteChildNode<TIndexer>(indexer, builderFactory())))
                .Concat(type.Methods.Select(method => new WriteChildNode<TMethod>(method, builderFactory())));
            steps.AddRange(typeSteps, () => steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }
        
        internal static void AddClassMemberVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            ClassMemberVisibilityModifier visibility)
        {
            if (visibility == ClassMemberVisibilityModifier.None)
            {
                return;
            }

            if (visibility == ClassMemberVisibilityModifier.ProtectedInternal)
            {
                steps.Add(new WriteClassMemberVisibilityModifier(ClassMemberVisibilityModifier.Protected));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteClassMemberVisibilityModifier(ClassMemberVisibilityModifier.Internal));
                steps.Add(new WriteWhitespace());
            }
            else
            {
                steps.Add(new WriteClassMemberVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }

        internal static void AddStructMemberVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            StructMemberVisibilityModifier visibility)
        {
            if (visibility == StructMemberVisibilityModifier.None)
            {
                return;
            }

            steps.Add(new WriteStructMemberVisibilityModifier(visibility));
            steps.Add(new WriteWhitespace());
        }

        internal static void AddClassMemberInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            ClassMemberInheritanceModifier inheritanceModifer)
        {
            switch (inheritanceModifer)
            {
                case ClassMemberInheritanceModifier.None:
                    return;
                case ClassMemberInheritanceModifier.Abstract:
                case ClassMemberInheritanceModifier.New:
                case ClassMemberInheritanceModifier.Override:
                case ClassMemberInheritanceModifier.Static:
                case ClassMemberInheritanceModifier.Virtual:
                    steps.Add(new WriteClassMemberInheritanceModifier(inheritanceModifer));
                    break;
                case ClassMemberInheritanceModifier.NewStatic:
                    steps.Add(new WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier.Static));
                    break;
                case ClassMemberInheritanceModifier.NewVirtual:
                    steps.Add(new WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier.Virtual));
                    break;
                case ClassMemberInheritanceModifier.SealedOverride:
                    steps.Add(new WriteSealed());
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier.Override));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddFieldModifierSteps(this List<ISourceCodeBuilderStep> steps, FieldModifier modifier)
        {
            switch (modifier)
            {
                case FieldModifier.None:
                    return;
                case FieldModifier.StaticReadOnly:
                    steps.Add(new WriteFieldModifier(FieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteFieldModifier(FieldModifier.ReadOnly));
                    break;
                case FieldModifier.StaticVolatile:
                    steps.Add(new WriteFieldModifier(FieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteFieldModifier(FieldModifier.Volatile));
                    break;
                default:
                    steps.Add(new WriteFieldModifier(modifier));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddGenericParameterTypeConstraintStep(
            this List<ISourceCodeBuilderStep> steps,
            GenericParameterTypeConstraint constraint)
        {
            switch (constraint)
            {
                case GenericParameterTypeConstraint.Class:
                    steps.Add(new WriteClassKeyword());
                    break;
                case GenericParameterTypeConstraint.Struct:
                    steps.Add(new WriteStructKeyword());
                    break;
            }
        }

        internal static void AddMethodParameterModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            ParameterModifier modifier)
        {
            if (modifier != ParameterModifier.None)
            {
                steps.Add(new WriteMethodParameterModifier(modifier));
                steps.Add(new WriteWhitespace());
            }
        }

        internal static void AddBlockSteps<TStatement>(this List<ISourceCodeBuilderStep> steps, IReadOnlyList<TStatement> statements)
            where TStatement : IStatement
        {
            steps.Add(new WriteStartBrace());
            steps.AddIndentedStatementSteps(statements);
            steps.Add(new WriteEndBrace());
        }

        internal static void AddIndentedStatementSteps<TStatement>(this List<ISourceCodeBuilderStep> steps, TStatement statement)
            where TStatement : IStatement
        {
            if (statement is IBlockStatement)
            {
                steps.Add(new WriteStatement<TStatement>(statement));
            }
            else
            {
                steps.Add(new IncrementIndent());
                steps.Add(new WriteIndentedNewLine());
                steps.Add(new WriteStatement<TStatement>(statement));
                steps.Add(new DecrementIndent());
            }
        }

        internal static void AddIndentedStatementSteps<TStatement>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyList<TStatement> statements)
            where TStatement : IStatement
        {
            steps.Add(new IncrementIndent());
            steps.AddStatementStepsOnNewLines(statements);
            steps.Add(new DecrementIndent());
        }

        internal static void AddStatementStepsOnNewLines<TStatement>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<TStatement> statements)
            where TStatement : IVisitable<IGenericStatementVisitor>
        {
            foreach (TStatement statement in statements)
            {
                steps.Add(new WriteIndentedNewLine());
                steps.Add(new WriteStatement<TStatement>(statement));
            }
        }

        internal static void AddListInitializerSteps<TExpression>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyList<IReadOnlyList<TExpression>> listInitializer,
            bool addComma = false)
            where TExpression : IExpression
        {
            foreach (IReadOnlyList<TExpression> initialValues in listInitializer)
            {
                steps.AddCommaIfNecessary(addComma);
                addComma = true;
                steps.Add(new WriteIndentedNewLine());
                if (initialValues.Count > 1)
                {
                    steps.Add(new WriteStartBrace());
                    steps.Add(new WriteWhitespace());
                }

                steps.AddCommaSeparatedExpressionSteps(initialValues);
                if (initialValues.Count > 1)
                {
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteEndBrace());
                }
            }
        }
            

        internal static void AddObjectInitializerSteps<TExpression, TObjectInitializer>(
            this List<ISourceCodeBuilderStep> steps,
            IHasObjectInitializers<TExpression, TObjectInitializer> objectInitializer)
            where TExpression : IExpression
            where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
        {
            steps.Add(new WriteIndentedNewLine());
            steps.Add(new WriteStartBrace());
            steps.Add(new IncrementIndent());
            bool addComma = false;
            foreach (KeyValuePair<string, TExpression> expression in objectInitializer.Members)
            {
                steps.AddCommaIfNecessary(addComma);
                addComma = true;
                steps.Add(new WriteIndentedNewLine());
                steps.Add(new WriteName(expression.Key));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteEquals());
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteExpression<TExpression>(expression.Value));
            }

            foreach (KeyValuePair<string, TObjectInitializer> initializer in objectInitializer.Initializers)
            {
                steps.AddCommaIfNecessary(addComma);
                addComma = true;
                steps.Add(new WriteIndentedNewLine());
                steps.Add(new WriteName(initializer.Key));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteEquals());
                steps.Add(new WriteWhitespace());
                steps.AddObjectInitializerSteps(initializer.Value);
            }

            steps.AddListInitializerSteps(objectInitializer.Elements, addComma);
            steps.Add(new DecrementIndent());
            steps.Add(new WriteIndentedNewLine());
            steps.Add(new WriteEndBrace());
        }

        internal static void AddCommaIfNecessary(this IList<ISourceCodeBuilderStep> steps, bool addComma)
        {
            if (addComma)
            {
                steps.Add(new WriteComma());
            }
        }

        internal static void AddStepIfNecessary(this List<ISourceCodeBuilderStep> steps, bool test, ISourceCodeBuilderStep step)
        {
            if (test)
            {
                steps.Add(step);
            }
        }
        
        private static void JoinList<T>(IEnumerable<T> items, Action<T> addAction, Action joinAction)
        {
            if (items.Any())
            {
                addAction(items.First());
                foreach (T item in items.Skip(1))
                {
                    joinAction();
                    addAction(item);
                }
            }
        }

        private static Predicate<ISourceCodeBuilderStep> GetTypePredicate(Type type)
        {
            return step => type.IsAssignableFrom(step.GetType());
        }

        private static int? AsNullable(int index)
        {
            return index < 0 ? (int?)null : index;
        }
    }
}