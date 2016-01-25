using CSharpDom.Common;
using CSharpDom.Text.Steps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Text
{
    internal static class ListExtensions
    {
        public static string ToSourceCode(this List<ISourceCodeBuilderStep> steps)
        {
            SourceCodeTextBuilder textBuilder = new SourceCodeTextBuilder();
            foreach (ISourceCodeBuilderStep step in steps)
            {
                step.AddText(textBuilder);
            }

            return textBuilder.ToString();
        }

        public static void AddRange(this List<ISourceCodeBuilderStep> steps, params ISourceCodeBuilderStep[] stepsToAdd)
        {
            steps.AddRange(stepsToAdd);
        }

        public static void AddCommaSeparatedRange(this List<ISourceCodeBuilderStep> steps, params ISourceCodeBuilderStep[] stepsToAdd)
        {
            steps.AddRange(stepsToAdd, () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
        }

        public static void AddRange(
            this List<ISourceCodeBuilderStep> steps,
            IEnumerable<ISourceCodeBuilderStep> stepsToAdd,
            Action joinFunction)
        {
            JoinList(stepsToAdd, step => steps.Add(step), joinFunction);
        }
        
        public static void AddChildNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes,
            Action joinFunction)
            where T : IVisitable<IGenericVisitor>
        {
            JoinList(childNodes, childNode => steps.Add(new WriteChildNode<T>(childNode)), joinFunction);
        }

        public static void AddChildNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes)
            where T : IVisitable<IGenericVisitor>
        {
            steps.AddChildNodeSteps(childNodes, () => { });
        }

        public static void AddCommaSeparatedChildNodeSteps<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes)
            where T : IVisitable<IGenericVisitor>
        {
            steps.AddChildNodeSteps(childNodes, () => steps.AddRange(new WriteComma(), new WriteWhitespace()));
        }

        public static void AddChildNodeStepsOnNewLines<T>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<T> childNodes)
            where T : IVisitable<IGenericVisitor>
        {
            foreach (T childNode in childNodes)
            {
                steps.Add(new WriteChildNode<T>(childNode));
                steps.Add(new WriteIndentedNewLine());
            }
        }

        public static void AddTypeVisibilityModifierSteps(this List<ISourceCodeBuilderStep> steps, TypeVisibilityModifier visibility)
        {
            if (visibility != TypeVisibilityModifier.None)
            {
                steps.Add(new WriteTypeVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }

        public static void AddTypeInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            TypeInheritanceModifier inheritanceModifier)
        {
            if (inheritanceModifier != TypeInheritanceModifier.None)
            {
                steps.Add(new WriteTypeInheritanceModifier(inheritanceModifier));
                steps.Add(new WriteWhitespace());
            }
        }

        public static void AddGenericParameterSteps<TGenericParameter>(
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

        public static void AddBaseClassAndImplementedInterfacesSteps<TClassReference, TInterfaceReference>(
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

        public static void AddImplementedInterfacesSteps<TInterfaceReference>(
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

        public static void AddGenericParameterConstraintSteps<TGenericParameter>(
            this List<ISourceCodeBuilderStep> steps,
            IReadOnlyCollection<TGenericParameter> genericParameters)
            where TGenericParameter : IVisitable<IGenericVisitor>
        {
            if (genericParameters.Count != 0)
            {
                steps.Add(new IncrementIndent());
                steps.Add(new WriteIndentedNewLine());
                steps.AddChildNodeStepsOnNewLines(genericParameters);
                steps.Add(new DecrementIndent());
            }
        }

        public static void AddInterfaceBodySteps<TEvent, TProperty, TIndexer, TMethod>(
            this List<ISourceCodeBuilderStep> steps,
            IBasicType<TEvent, TProperty, TIndexer, TMethod> type)
            where TEvent : IEvent
            where TProperty : IProperty
            where TIndexer : IIndexer
            where TMethod : IMethod
        {
            Func<SourceCodeStepsBuilder> builderFactory = () => new SourceCodeStepsBuilder(true);
            IEnumerable<ISourceCodeBuilderStep> typeSteps =
                type.Events.Select(@event => (ISourceCodeBuilderStep)new WriteChildNode<TEvent>(@event, builderFactory()))
                .Concat(type.Properties.Select(property => new WriteChildNode<TProperty>(property, builderFactory())))
                .Concat(type.Indexers.Select(indexer => new WriteChildNode<TIndexer>(indexer, builderFactory())))
                .Concat(type.Methods.Select(method => new WriteChildNode<TMethod>(method, builderFactory())));
            steps.AddRange(typeSteps, () => steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public static void AddTypeBodySteps<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            this List<ISourceCodeBuilderStep> steps,
            IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> type,
            ISourceCodeBuilderStep destructorStep = null)
            where TEvent : IEvent
            where TProperty : IProperty
            where TIndexer : IIndexer
            where TMethod : IMethod
            where TField : IField
            where TConstructor : IConstructor
            where TEventProperty : IEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : INestedClass
            where TNestedDelegate : INestedDelegate
            where TNestedEnum : INestedEnum
            where TNestedInterface : INestedInterface
            where TNestedStruct : INestedStruct
        {
            IEnumerable<ISourceCodeBuilderStep> typeSteps =
                type.Fields.Select(field => (ISourceCodeBuilderStep)new WriteChildNode<TField>(field))
                .Concat(type.Events.Select(@event => new WriteChildNode<TEvent>(@event)))
                .Concat(type.EventProperties.Select(eventProperty => new WriteChildNode<TEventProperty>(eventProperty)))
                .Concat(type.Constructors.Select(constructor => new WriteChildNode<TConstructor>(constructor)))
                .Concat(destructorStep == null ? new ISourceCodeBuilderStep[0] : new ISourceCodeBuilderStep[] { destructorStep })
                .Concat(type.Properties.Select(property => new WriteChildNode<TProperty>(property)))
                .Concat(type.Indexers.Select(indexer => new WriteChildNode<TIndexer>(indexer)))
                .Concat(type.Methods.Select(method => new WriteChildNode<TMethod>(method)))
                .Concat(type.OperatorOverloads.Select(@operator => new WriteChildNode<TOperatorOverload>(@operator)))
                .Concat(type.ConversionOperators.Select(@operator => new WriteChildNode<TConversionOperator>(@operator)))
                .Concat(type.Classes.Select(@class => new WriteChildNode<TNestedClass>(@class)))
                .Concat(type.Delegates.Select(@delegate => new WriteChildNode<TNestedDelegate>(@delegate)))
                .Concat(type.Enums.Select(@enum => new WriteChildNode<TNestedEnum>(@enum)))
                .Concat(type.Interfaces.Select(@interface => new WriteChildNode<TNestedInterface>(@interface)))
                .Concat(type.Structs.Select(@struct => new WriteChildNode<TNestedStruct>(@struct)));
            steps.AddRange(typeSteps, () => steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public static void AddMemberVisibilityModifierSteps(this List<ISourceCodeBuilderStep> steps, MemberVisibilityModifier visibility)
        {
            if (visibility == MemberVisibilityModifier.None)
            {
                return;
            }

            if (visibility == MemberVisibilityModifier.ProtectedInternal)
            {
                steps.Add(new WriteMemberVisibilityModifier(MemberVisibilityModifier.Protected));
                steps.Add(new WriteWhitespace());
                steps.Add(new WriteMemberVisibilityModifier(MemberVisibilityModifier.Internal));
                steps.Add(new WriteWhitespace());
            }
            else
            {
                steps.Add(new WriteMemberVisibilityModifier(visibility));
                steps.Add(new WriteWhitespace());
            }
        }

        public static void AddMemberInheritanceModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            MemberInheritanceModifier inheritanceModifer)
        {
            switch (inheritanceModifer)
            {
                case MemberInheritanceModifier.None:
                    return;
                case MemberInheritanceModifier.Abstract:
                case MemberInheritanceModifier.New:
                case MemberInheritanceModifier.Override:
                case MemberInheritanceModifier.Static:
                case MemberInheritanceModifier.Virtual:
                    steps.Add(new WriteMemberInheritanceModifier(inheritanceModifer));
                    break;
                case MemberInheritanceModifier.NewStatic:
                    steps.Add(new WriteMemberInheritanceModifier(MemberInheritanceModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteMemberInheritanceModifier(MemberInheritanceModifier.Static));
                    break;
                case MemberInheritanceModifier.NewVirtual:
                    steps.Add(new WriteMemberInheritanceModifier(MemberInheritanceModifier.New));
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteMemberInheritanceModifier(MemberInheritanceModifier.Virtual));
                    break;
                case MemberInheritanceModifier.SealedOverride:
                    steps.Add(new WriteSealed());
                    steps.Add(new WriteWhitespace());
                    steps.Add(new WriteMemberInheritanceModifier(MemberInheritanceModifier.Override));
                    break;
            }

            steps.Add(new WriteWhitespace());
        }

        public static void AddFieldModifierSteps(this List<ISourceCodeBuilderStep> steps, FieldModifier modifier)
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

        public static void AddGenericParameterTypeConstraintStep(
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

        public static void AddMethodParameterModifierSteps(
            this List<ISourceCodeBuilderStep> steps,
            MethodParameterModifier modifier)
        {
            if (modifier != MethodParameterModifier.None)
            {
                steps.Add(new WriteMethodParameterModifier(modifier));
                steps.Add(new WriteWhitespace());
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
    }
}
