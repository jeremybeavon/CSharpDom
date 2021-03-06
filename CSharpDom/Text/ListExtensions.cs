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
        public static SourceCodeStepRange GetRange(
            this List<ISourceCodeBuilderStep> steps,
            SourceCodePlaceholder startPlaceholder,
            SourceCodePlaceholder endPlaceholder)
        {
            int? startIndex = steps.FindIndex(startPlaceholder);
            int? endIndex = steps.FindIndex(endPlaceholder);
            if (!startIndex.HasValue && !endIndex.HasValue)
            {
                return null;
            }

            int length = endIndex.Value - startIndex.Value;
            if (length <= 0)
            {
                return null;
            }

            return new SourceCodeStepRange(steps, steps.GetRange(startIndex.Value, length), startPlaceholder, endPlaceholder);
        }

        public static void AddIfNotEmpty<TChildNode>(this List<ISourceCodeBuilderStep> steps, TChildNode childNode)
            where TChildNode : IVisitable<IGenericVisitor>
        {
            WriteChildNode<TChildNode> node = new WriteChildNode<TChildNode>(childNode);
            if (node.Steps.Count != 0)
            {
                steps.Add(node);
            }
        }

        public static void AddIfNotNull<TChildNode>(this List<ISourceCodeBuilderStep> steps, TChildNode childNode)
            where TChildNode : IVisitable<IGenericVisitor>
        {
            if (childNode != null)
            {
                steps.Add(new WriteChildNode<TChildNode>(childNode));
            }
        }

        public static IEnumerable<ChildSteps> GetChildSteps(this List<ISourceCodeBuilderStep> steps)
        {
            foreach (ISourceCodeBuilderStep step in steps)
            {
                IHasStatement hasStatement = step as IHasStatement;
                IHasExpression hasExpression = step as IHasExpression;
                if (step is IHasChildNode hasChildNode)
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

                if (step is IHasSourceSourceBuilderSteps hasChildSteps)
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

        public static int? FindIndex(this List<ISourceCodeBuilderStep> steps, SourceCodePlaceholder placeholder)
        {
            return AsNullable(steps.FindIndex(GetPlaceholderPredicate(placeholder)));
        }

        public static int? FindLastIndex(this List<ISourceCodeBuilderStep> steps, Type type)
        {
            return AsNullable(steps.FindLastIndex(GetTypePredicate(type)));
        }

        public static List<ISourceCodeBuilderStep> FindFirstLine(this List<ISourceCodeBuilderStep> steps)
        {
            int? newLineIndex = steps.FindIndex(typeof(WriteIndentedNewLine));
            return newLineIndex.HasValue ? steps.GetRange(0, newLineIndex.Value) : steps;
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

        public static void ReplaceAll(
            this List<ISourceCodeBuilderStep> steps,
            Type stepType,
            ISourceCodeBuilderStep replacementStep)
        {
            int index = 0;
            foreach (ISourceCodeBuilderStep step in steps.ToArray())
            {
                if (DoesStepMatchType(step, stepType))
                {
                    steps[index] = replacementStep;
                }

                index++;
            }
        }

        public static string ToSourceCode(this List<ISourceCodeBuilderStep> steps, params ISourceCodeStyleRule[] styleRules)
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

        internal static void AddPlaceholder(this List<ISourceCodeBuilderStep> steps, SourceCodePlaceholder placeholder)
        {
            steps.Add(new PlaceholderStep(placeholder));
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

        internal static void AddReturnAttributeNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes)
            where T : IVisitable<IGenericVisitor>
        {
            steps.AddChildNodeStepsOnNewLines(
                childNodes,
                builderFactory: () => new SourceCodeStepsBuilder() { IsReturnAttributeGroup = true });
        }

        internal static void AddChildNodeStepsOnNewLines<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes,
            NewLineLocation location = NewLineLocation.AfterNode,
            Func<SourceCodeStepsBuilder> builderFactory = null)
            where T : IVisitable<IGenericVisitor>
        {
            if (builderFactory == null)
            {
                builderFactory = () => null;
            }

            foreach (T childNode in childNodes)
            {
                if (location == NewLineLocation.BeforeNode)
                {
                    steps.Add(new WriteIndentedNewLine());
                }

                steps.Add(new WriteChildNode<T>(childNode, builderFactory()));
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

        internal static void AddGenericParameterDeclarationSteps<TGenericParameter>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyList<TGenericParameter> genericParameters)
            where TGenericParameter : IGenericParameterDeclaration
        {
            if (genericParameters.Count != 0)
            {
                steps.Add(new WriteStartGenericParameters());
                steps.AddPlaceholder(SourceCodePlaceholder.BeginGenericParametersDefinition);
                steps.AddRange(
                    genericParameters.Select(parameter => new WriteName(((IHasName)parameter).Name)),
                    () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
                steps.AddPlaceholder(SourceCodePlaceholder.EndGenericParametersDefinition);
                steps.Add(new WriteEndGenericParameters());
            }
        }

        internal static void AddGenericParameterSteps<TTypeReference>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyList<TTypeReference> genericParameters)
            where TTypeReference : ITypeReference
        {
            if (genericParameters.Count != 0)
            {
                steps.Add(new WriteStartGenericParameters());
                steps.AddCommaSeparatedChildNodeSteps(genericParameters);
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
                steps.AddPlaceholder(SourceCodePlaceholder.BeginBaseTypeList);
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteChildNode<TClassReference>(baseClassContainer.BaseClass));
            }

            if (implementedInterfaces.ImplementedInterfaces.Count != 0)
            {
                if (baseClassContainer.BaseClass == null)
                {
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteColon());
                    steps.AddPlaceholder(SourceCodePlaceholder.BeginBaseTypeList);
                    steps.Add(new WriteWhitespace());
                }
                else
                {
                    steps.Add(new WriteComma());
                    steps.Add(new WriteWhitespace());
                }

                steps.AddCommaSeparatedChildNodeSteps(implementedInterfaces.ImplementedInterfaces);
            }

            if (baseClassContainer.BaseClass != null || implementedInterfaces.ImplementedInterfaces.Count != 0)
            {
                steps.AddPlaceholder(SourceCodePlaceholder.EndBaseTypeList);
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
                steps.AddPlaceholder(SourceCodePlaceholder.BeginBaseTypeList);
                steps.Add(new WriteWhitespace());
                steps.AddCommaSeparatedChildNodeSteps(implementedInterfaces.ImplementedInterfaces);
                steps.AddPlaceholder(SourceCodePlaceholder.EndBaseTypeList);
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

        internal static void AddInterfaceBodySteps<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            this List<ISourceCodeBuilderStep> steps,
            IInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            ISourceCodeBuilderStep[] typeSteps =
                type.Events.ToSteps()
                .Concat(type.Properties.ToSteps())
                .Concat(type.Indexers.ToSteps())
                .Concat(type.Methods.ToSteps())
                .ToArray();
            if (typeSteps.Length != 0)
            {
                steps.Add(new WriteIndentedNewLine());
            }

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

        internal static void AddAbstractMemberVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            AbstractMemberVisibilityModifier visibility)
        {
            if (visibility == AbstractMemberVisibilityModifier.None)
            {
                return;
            }

            if (visibility == AbstractMemberVisibilityModifier.ProtectedInternal)
            {
                steps.Add(new WriteAbstractMemberVisibilityModifier(AbstractMemberVisibilityModifier.Protected));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteAbstractMemberVisibilityModifier(AbstractMemberVisibilityModifier.Internal));
                steps.Add(new WriteWhitespace());
            }
            else
            {
                steps.Add(new WriteAbstractMemberVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }

        internal static void AddStaticClassMemberVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            StaticClassMemberVisibilityModifier visibility)
        {
            if (visibility == StaticClassMemberVisibilityModifier.None)
            {
                return;
            }

            steps.Add(new WriteStaticClassMemberVisibilityModifier(visibility));
            steps.Add(new WriteWhitespace());
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

        internal static void AddClassAccessorVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            ClassAccessorVisibilityModifier visibility)
        {
            if (visibility == ClassAccessorVisibilityModifier.None)
            {
                return;
            }

            if (visibility == ClassAccessorVisibilityModifier.ProtectedInternal)
            {
                steps.Add(new WriteClassAccessorVisibilityModifier(ClassAccessorVisibilityModifier.Protected));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteClassAccessorVisibilityModifier(ClassAccessorVisibilityModifier.Internal));
                steps.Add(new WriteWhitespace());
            }
            else
            {
                steps.Add(new WriteClassAccessorVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }

        internal static void AddAbstractAccessorVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            AbstractAccessorVisibilityModifier visibility)
        {
            if (visibility == AbstractAccessorVisibilityModifier.None)
            {
                return;
            }

            if (visibility == AbstractAccessorVisibilityModifier.ProtectedInternal)
            {
                steps.Add(new WriteAbstractAccessorVisibilityModifier(AbstractAccessorVisibilityModifier.Protected));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteAbstractAccessorVisibilityModifier(AbstractAccessorVisibilityModifier.Internal));
                steps.Add(new WriteWhitespace());
            }
            else
            {
                steps.Add(new WriteAbstractAccessorVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }

        internal static void AddStaticClassAccessorVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            StaticClassAccessorVisibilityModifier visibility)
        {
            if (visibility == StaticClassAccessorVisibilityModifier.None)
            {
                return;
            }

            steps.Add(new WriteStaticClassAccessorVisibilityModifier(visibility));
            steps.Add(new WriteWhitespace());
        }

        internal static void AddStructAccessorVisibilityModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            StructAccessorVisibilityModifier visibility)
        {
            if (visibility == StructAccessorVisibilityModifier.None)
            {
                return;
            }

            steps.Add(new WriteStructAccessorVisibilityModifier(visibility));
            steps.Add(new WriteWhitespace());
        }

        internal static void AddStructMemberInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            StructMemberInheritanceModifier modifier)
        {
            if (modifier == StructMemberInheritanceModifier.None)
            {
                return;
            }

            steps.Add(new WriteStatic());
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

        internal static void AddInterfaceMemberInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            InterfaceMemberInheritanceModifier inheritanceModifer)
        {
            if (inheritanceModifer == InterfaceMemberInheritanceModifier.None)
            {
                return;
            }

            steps.Add(new WriteInterfaceMemberInheritanceModifier(inheritanceModifer));
            steps.Add(new WriteWhitespace());
        }

        internal static void AddSealedClassMemberInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            SealedClassMemberInheritanceModifier inheritanceModifer)
        {
            switch (inheritanceModifer)
            {
                case SealedClassMemberInheritanceModifier.None:
                    return;
                case SealedClassMemberInheritanceModifier.New:
                case SealedClassMemberInheritanceModifier.Override:
                case SealedClassMemberInheritanceModifier.Static:
                    steps.Add(new WriteSealedClassMemberInheritanceModifier(inheritanceModifer));
                    break;
                case SealedClassMemberInheritanceModifier.NewStatic:
                    steps.Add(new WriteSealedClassMemberInheritanceModifier(SealedClassMemberInheritanceModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteSealedClassMemberInheritanceModifier(SealedClassMemberInheritanceModifier.Static));
                    break;
                case SealedClassMemberInheritanceModifier.SealedOverride:
                    steps.Add(new WriteSealed());
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteSealedClassMemberInheritanceModifier(SealedClassMemberInheritanceModifier.Override));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddIndexerInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            IndexerInheritanceModifier inheritanceModifer)
        {
            switch (inheritanceModifer)
            {
                case IndexerInheritanceModifier.None:
                    return;
                case IndexerInheritanceModifier.New:
                case IndexerInheritanceModifier.Override:
                case IndexerInheritanceModifier.Virtual:
                    steps.Add(new WriteIndexerInheritanceModifier(inheritanceModifer));
                    break;
                case IndexerInheritanceModifier.NewVirtual:
                    steps.Add(new WriteIndexerInheritanceModifier(IndexerInheritanceModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteIndexerInheritanceModifier(IndexerInheritanceModifier.Virtual));
                    break;
                case IndexerInheritanceModifier.SealedOverride:
                    steps.Add(new WriteSealed());
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteIndexerInheritanceModifier(IndexerInheritanceModifier.Override));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddSealedClassIndexerInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            SealedClassIndexerInheritanceModifier inheritanceModifer)
        {
            switch (inheritanceModifer)
            {
                case SealedClassIndexerInheritanceModifier.None:
                    return;
                case SealedClassIndexerInheritanceModifier.New:
                case SealedClassIndexerInheritanceModifier.Override:
                    steps.Add(new WriteSealedClassIndexerInheritanceModifier(inheritanceModifer));
                    break;
                case SealedClassIndexerInheritanceModifier.SealedOverride:
                    steps.Add(new WriteSealed());
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteSealedClassIndexerInheritanceModifier(SealedClassIndexerInheritanceModifier.Override));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddClassFieldModifierSteps(this List<ISourceCodeBuilderStep> steps, ClassFieldModifier modifier)
        {
            switch (modifier)
            {
                case ClassFieldModifier.None:
                    return;
                case ClassFieldModifier.NewReadOnly:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.ReadOnly));
                    break;
                case ClassFieldModifier.NewStatic:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Static));
                    break;
                case ClassFieldModifier.NewStaticReadOnly:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.ReadOnly));
                    break;
                case ClassFieldModifier.NewStaticVolatile:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Volatile));
                    break;
                case ClassFieldModifier.NewVolatile:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Volatile));
                    break;
                case ClassFieldModifier.StaticReadOnly:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.ReadOnly));
                    break;
                case ClassFieldModifier.StaticVolatile:
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteClassFieldModifier(ClassFieldModifier.Volatile));
                    break;
                default:
                    steps.Add(new WriteClassFieldModifier(modifier));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddStructFieldModifierSteps(this List<ISourceCodeBuilderStep> steps, StructFieldModifier modifier)
        {
            switch (modifier)
            {
                case StructFieldModifier.None:
                    return;
                case StructFieldModifier.StaticReadOnly:
                    steps.Add(new WriteStructFieldModifier(StructFieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteStructFieldModifier(StructFieldModifier.ReadOnly));
                    break;
                case StructFieldModifier.StaticVolatile:
                    steps.Add(new WriteStructFieldModifier(StructFieldModifier.Static));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteStructFieldModifier(StructFieldModifier.Volatile));
                    break;
                default:
                    steps.Add(new WriteStructFieldModifier(modifier));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        internal static void AddStaticClassFieldModifierSteps(this List<ISourceCodeBuilderStep> steps, StaticClassFieldModifier modifier)
        {
            if (modifier == StaticClassFieldModifier.None)
            {
                return;
            }

            steps.Add(new WriteStaticClassFieldModifier(modifier));
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
            steps.Add(new WriteIndentedNewLine());
            steps.Add(new WriteEndBrace());
        }

        internal static void AddIndentedStatementSteps<TStatement>(this List<ISourceCodeBuilderStep> steps, TStatement statement)
            where TStatement : IStatement
        {
            if (statement is IBlockStatement)
            {
                steps.Add(new WriteIndentedNewLine());
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
                    joinAction?.Invoke();
                    addAction(item);
                }
            }
        }

        private static Predicate<ISourceCodeBuilderStep> GetTypePredicate(Type type)
        {
            return step => DoesStepMatchType(step, type);
        }

        private static bool DoesStepMatchType(ISourceCodeBuilderStep step, Type type)
        {
            return type.IsAssignableFrom(step.GetType());
        }

        private static Predicate<ISourceCodeBuilderStep> GetPlaceholderPredicate(SourceCodePlaceholder placeholder)
        {
            return step => step is PlaceholderStep placeHolderStep && placeHolderStep.Placeholder == placeholder;
        }

        private static int? AsNullable(int index)
        {
            return index < 0 ? (int?)null : index;
        }
    }
}
