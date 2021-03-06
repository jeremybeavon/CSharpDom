﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Common.Statements;
using CSharpDom.Text.Steps;
using CSharpDom.Text.Steps.Expressions;
using CSharpDom.Text.Steps.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpDom.Text
{
    public sealed class SourceCodeStepsBuilder : AbstractGenericVisitor, IHasSourceSourceBuilderSteps
    {
        private readonly AccessorFlags accessorFlags;
        private readonly ITypeReference accessorType;
        private readonly string emptyBodyText;
        private ISourceCodeBuilderStep explicitInterface;
        private bool isAttribute;
        private ISourceCodeBuilderStep[] destructorStep;
        private bool isPartial;
        private Action accessorVisibilityAction;

        public SourceCodeStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
            destructorStep = new ISourceCodeBuilderStep[0];
        }

        internal SourceCodeStepsBuilder(string emptyBodyText)
            : this()
        {
            this.emptyBodyText = emptyBodyText;
        }
        
        internal SourceCodeStepsBuilder(
            AccessorFlags accessorFlags = AccessorFlags.None,
            ITypeReference accessorType = null)
            : this()
        {
            this.accessorFlags = accessorFlags;
            this.accessorType = accessorType;
        }
        
        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        internal bool IsReturnAttributeGroup { get; set; }

        public override void VisitClassAccessor<TAttributeGroup, TMethodBody>(
            IClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            accessorVisibilityAction = () => Steps.AddClassAccessorVisibilityModifierSteps(accessor.Visibility);
            VisitAccessor(accessor);
        }

        public override void VisitInterfaceAccessor<TAttributeGroup>(IInterfaceAccessor<TAttributeGroup> accessor)
        {
            Steps.AddChildNodeSteps(accessor.Attributes);
            Steps.Add(accessorFlags.HasFlag(AccessorFlags.Get) ? (ISourceCodeBuilderStep)new WriteGetKeyword() : new WriteSetKeyword());
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitStructAccessor<TAttributeGroup, TMethodBody>(
            IStructAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            accessorVisibilityAction = () => Steps.AddStructAccessorVisibilityModifierSteps(accessor.Visibility);
            VisitAccessor(accessor);
        }

        public override void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Steps.Add(accessor.Body == null ? (ISourceCodeBuilderStep)new WriteWhitespace() : new WriteIndentedNewLine());
            accessorVisibilityAction?.Invoke();
            ISourceCodeBuilderStep accessorKeyword = accessorFlags.HasFlag(AccessorFlags.Get) ? (ISourceCodeBuilderStep)new WriteGetKeyword() : new WriteSetKeyword();
            if (accessor.Body == null)
            {
                Steps.AddRange(accessor.Attributes.ToSteps());
                Steps.Add(accessorKeyword);
                Steps.Add(new WriteSemicolon());
                return;
            }

            WriteChildNode<TMethodBody> methodBody;
            if (accessorFlags.HasFlag(AccessorFlags.Get))
            {
                string typeText = new WriteChildNode<ITypeReference>(accessorType).Steps.ToSourceCode();
                string emptyBodyText = string.Format("return default({0});", typeText);
                methodBody = new WriteChildNode<TMethodBody>(accessor.Body, new SourceCodeStepsBuilder(emptyBodyText));
            }
            else
            {
                methodBody = new WriteChildNode<TMethodBody>(accessor.Body);
            }


            Steps.AddChildNodeStepsOnNewLines(accessor.Attributes);
            Steps.Add(accessorKeyword);
            bool hasSingleLine = methodBody.Steps.OfType<WriteIndentedNewLine>().SingleOrDefault() != null;
            if (methodBody.Steps.Count == 0)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteStartBrace());
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteEndBrace());
            }
            else if (methodBody.Steps.Count != 1 && !hasSingleLine)
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteStartBrace());
                Steps.Add(new IncrementIndent());
                Steps.Add(methodBody);
                Steps.Add(new DecrementIndent());
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteEndBrace());
            }
            else
            {
                if (hasSingleLine)
                {
                    methodBody.Steps.RemoveAt(0);
                }

                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteStartBrace());
                Steps.Add(new WriteWhitespace());
                Steps.Add(methodBody);
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteEndBrace());
            }
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(arrayTypeReference.ElementType));
            Steps.Add(new WriteStartBracket());
            if (arrayTypeReference.Dimensions > 1)
            {
                Steps.AddRange(Enumerable.Repeat(new WriteComma(), arrayTypeReference.Dimensions - 1));
            }

            Steps.Add(new WriteEndBracket());
        }

        public override void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
        {
            SourceCodeStepsBuilder stepsBuilder = new SourceCodeStepsBuilder() { isAttribute = true };
            Steps.Add(new WriteChildNode<TClassReference>(attribute.AttributeType, stepsBuilder));
            if (attribute.UnnamedValues.Count == 0 && attribute.NamedValues.Count == 0)
            {
                return;
            }

            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(attribute.UnnamedValues);
            if (attribute.UnnamedValues.Count != 0 && attribute.NamedValues.Count != 0)
            {
                Steps.AddRange(new WriteComma(), new WriteWhitespace());
            }

            Steps.AddCommaSeparatedChildNodeSteps(attribute.NamedValues);
            Steps.Add(new WriteEndParenthesis());
        }

        public override void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
        {
            Steps.Add(new WriteStartBracket());
            if (IsReturnAttributeGroup)
            {
                Steps.Add(new WriteReturnKeyword());
                Steps.Add(new WriteColon());
                Steps.Add(new WriteWhitespace());
            }

            Steps.AddCommaSeparatedChildNodeSteps(attributes.Attributes);
            Steps.Add(new WriteEndBracket());
        }

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            Steps.AddChildNodeStepsOnNewLines(@class.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginTypeDefinition);
            Steps.AddTypeVisibilityModifierSteps(@class.Visibility);
            if (isPartial)
            {
                Steps.Add(new WritePartialKeyword());
                Steps.Add(new WriteWhitespace());
            }

            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterDeclarationSteps(@class.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(@class, @class);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndTypeDefinition);
            Steps.AddGenericParameterConstraintSteps(@class.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (@class.Destructor != null)
            {
                destructorStep = new ISourceCodeBuilderStep[]
                {
                    new WriteChildNode<TDestructor>(@class.Destructor)
                };
            }

            VisitType(@class);
            destructorStep = new ISourceCodeBuilderStep[0];
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            Steps.Add(new WriteBuiltInType(builtInTypeReference.Type));
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            if (isAttribute)
            {
                Steps.Add(new WriteName(Regex.Replace(classReference.Name, "Attribute$", string.Empty)));
                return;
            }

            Steps.Add(new WriteName(classReference.Name));
            Steps.AddGenericParameterSteps(classReference.GenericParameters);
        }

        public override void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Steps.Add(new WriteName(((IHasName)constructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(constructor.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteChildNode<TMethodBody>(constructor.Body));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Steps.AddChildNodeStepsOnNewLines(constructor.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(constructor.Visibility);
            VisitConstructor(constructor);
        }

        public override void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Steps.AddChildNodeStepsOnNewLines(constructor.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(constructor.Visibility);
            VisitConstructor(constructor);
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            Steps.AddChildNodeStepsOnNewLines(conversionOperator.Attributes);
            Steps.AddReturnAttributeNodeSteps(conversionOperator.ReturnAttributes);
            Steps.AddClassMemberVisibilityModifierSteps(ClassMemberVisibilityModifier.Public);
            Steps.AddClassMemberInheritanceModifierSteps(ClassMemberInheritanceModifier.Static);
            Steps.Add(new WriteConversionOperatorType(conversionOperator.OperatorType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteOperatorKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(conversionOperator.ReturnType));
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteChildNode<TParameter>(conversionOperator.Parameter));
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteChildNode<TMethodBody>(conversionOperator.Body));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            Steps.AddChildNodeStepsOnNewLines(@delegate.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@delegate.Visibility);
            Steps.Add(new WriteDelegateKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(@delegate.ReturnType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@delegate.Name));
            Steps.AddGenericParameterDeclarationSteps(@delegate.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(@delegate.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(@delegate.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            Steps.Add(new WriteName(delegateReference.Name));
            Steps.AddGenericParameterSteps(delegateReference.GenericParameters);
        }

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
            Steps.AddChildNodeStepsOnNewLines(destructor.Attributes);
            Steps.Add(new WriteTilda());
            Steps.Add(new WriteName(((IHasName)destructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteChildNode<TMethodBody>(destructor.Body));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            Steps.AddChildNodeStepsOnNewLines(@enum.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@enum.Visibility);
            Steps.Add(new WriteEnumKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@enum.Name));
            if (@enum.BaseType != EnumBaseType.None)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteColon());
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteEnumBaseType(@enum.BaseType));
            }

            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (@enum.EnumMembers.Count != 0)
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.AddChildNodeSteps(@enum.EnumMembers, () => Steps.AddRange(new WriteComma(), new WriteIndentedNewLine()));
            }

            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(
            IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            Steps.AddChildNodeStepsOnNewLines(enumMember.Attributes);
            Steps.Add(new WriteName(enumMember.Name));
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            Steps.Add(new WriteName(enumReference.Name));
        }

        public override void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddAbstractMemberVisibilityModifierSteps(@event.Visibility);
            Steps.Add(new WriteAbstractKeyword());
            Steps.Add(new WriteWhitespace());
            VisitEvent(@event);
        }

        public override void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddChildNodeStepsOnNewLines(@event.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(@event.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(@event.InheritanceModifier);
            VisitEvent(@event);
        }

        public override void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddChildNodeStepsOnNewLines(@event.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(@event.Visibility);
            Steps.AddSealedClassMemberInheritanceModifierSteps(@event.InheritanceModifier);
            VisitEvent(@event);
        }

        public override void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            VisitEvent(@event);
        }

        public override void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddChildNodeStepsOnNewLines(@event.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(@event.Visibility);
            Steps.AddStructMemberInheritanceModifierSteps(@event.InheritanceModifier);
            VisitEvent(@event);
        }

        public override void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.Add(new WriteEventKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TDelegateReference>(@event.EventType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@event.Name));
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Steps.AddChildNodeStepsOnNewLines(eventProperty.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(eventProperty.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(eventProperty.InheritanceModifier);
            VisitEventProperty(eventProperty);
        }

        public override void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Steps.AddChildNodeStepsOnNewLines(eventProperty.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(eventProperty.Visibility);
            Steps.AddSealedClassMemberInheritanceModifierSteps(eventProperty.InheritanceModifier);
            VisitEventProperty(eventProperty);
        }

        public override void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
        {
            Steps.AddChildNodeStepsOnNewLines(@event.Attributes);
            explicitInterface = new WriteChildNode<TInterfaceReference>(@event.ExplicitInterface);
            VisitEventProperty(@event);
            explicitInterface = null;
        }

        public override void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Steps.AddChildNodeStepsOnNewLines(eventProperty.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(eventProperty.Visibility);
            Steps.AddStructMemberInheritanceModifierSteps(eventProperty.InheritanceModifier);
            VisitEventProperty(eventProperty);
        }

        public override void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Steps.Add(new WriteEventKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TDelegateReference>(eventProperty.EventType));
            Steps.Add(new WriteWhitespace());
            if (explicitInterface != null)
            {
                Steps.Add(explicitInterface);
                Steps.Add(new WriteDot());
            }

            Steps.Add(new WriteName(eventProperty.Name));
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddChildNodeStepsOnNewLines(eventProperty.AddAttributes);
            Steps.Add(new WriteAddKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TMethodBody>(eventProperty.AddBody));
            Steps.Add(new WriteEndBrace());
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddChildNodeStepsOnNewLines(eventProperty.RemoveAttributes);
            Steps.Add(new WriteRemoveKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TMethodBody>(eventProperty.RemoveBody));
            Steps.Add(new WriteEndBrace());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitField<TExpression>(IField<TExpression> field)
        {
            Steps.Add(new WriteName(field.Name));
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field> field)
        {
            Steps.AddClassMemberVisibilityModifierSteps(field.Visibility);
            Steps.AddClassFieldModifierSteps(field.Modifier);
            VisitFieldGroup(field);
        }

        public override void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Steps.AddStructMemberVisibilityModifierSteps(field.Visibility);
            Steps.AddStructFieldModifierSteps(field.Modifier);
            VisitFieldGroup(field);
        }

        public override void VisitFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(field.FieldType));
            Steps.Add(new WriteWhitespace());
            Steps.AddCommaSeparatedChildNodeSteps(field.Fields);
            Steps.Add(new WriteSemicolon());
        }
        
        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
            if (genericParameterDeclaration.BaseClassConstraint == null &&
                genericParameterDeclaration.GenericParameterConstraints.Count == 0 &&
                !genericParameterDeclaration.HasEmptyConstructorConstraint &&
                genericParameterDeclaration.InterfaceConstraints.Count == 0 &&
                genericParameterDeclaration.TypeConstraint == GenericParameterTypeConstraint.None)
            {
                return;
            }

            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteWhere());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(genericParameterDeclaration.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteColon());
            Steps.Add(new WriteWhitespace());
            List<ISourceCodeBuilderStep> constraintSteps = new List<ISourceCodeBuilderStep>();
            if (genericParameterDeclaration.BaseClassConstraint != null)
            {
                constraintSteps.Add(new WriteChildNode<TClassReference>(genericParameterDeclaration.BaseClassConstraint));
            }
            else
            {
                constraintSteps.AddGenericParameterTypeConstraintStep(genericParameterDeclaration.TypeConstraint);
            }

            constraintSteps.AddChildNodeSteps(genericParameterDeclaration.GenericParameterConstraints);
            constraintSteps.AddChildNodeSteps(genericParameterDeclaration.InterfaceConstraints);
            if (genericParameterDeclaration.HasEmptyConstructorConstraint)
            {
                constraintSteps.Add(new WriteEmptyConstructorGenericParameterConstraint());
            }

            Steps.AddCommaSeparatedRange(constraintSteps.ToArray());
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            Steps.Add(new WriteName(genericParameterReference.Name));
        }

        public override void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            Steps.AddAbstractMemberVisibilityModifierSteps(indexer.Visibility);
            Steps.Add(new WriteAbstractKeyword());
            Steps.Add(new WriteWhitespace());
            VisitIndexer(indexer);
        }

        public override void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(indexer.Visibility);
            Steps.AddIndexerInheritanceModifierSteps(indexer.InheritanceModifier);
            VisitIndexer(indexer);
        }

        public override void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            explicitInterface = new WriteChildNode<TInterfaceReference>(indexer.ExplicitInterface);
            VisitIndexer(indexer);
            explicitInterface = null;
        }

        public override void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            Steps.AddInterfaceMemberInheritanceModifierSteps(indexer.InheritanceModifier);
            Steps.Add(new WriteChildNode<TTypeReference>(indexer.IndexerType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteThisKeyword());
            Steps.Add(new WriteStartBracket());
            Steps.AddCommaSeparatedChildNodeSteps(indexer.Parameters);
            Steps.Add(new WriteEndBracket());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            if (indexer.GetAccessor != null)
            {
                Steps.Add(new WriteGetKeyword());
                Steps.Add(new WriteSemicolon());
            }

            if (indexer.SetAccessor != null)
            {
                if (indexer.GetAccessor != null)
                {
                    Steps.Add(new WriteWhitespace());
                }

                Steps.Add(new WriteSetKeyword());
                Steps.Add(new WriteSemicolon());
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(indexer.Visibility);
            VisitIndexer(indexer);
        }

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(indexer.IndexerType));
            Steps.Add(new WriteWhitespace());
            if (explicitInterface != null)
            {
                Steps.Add(explicitInterface);
                Steps.Add(new WriteDot());
            }

            Steps.Add(new WriteThisKeyword());
            Steps.Add(new WriteStartBracket());
            Steps.AddCommaSeparatedChildNodeSteps(indexer.Parameters);
            Steps.Add(new WriteEndBracket());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            SourceCodeStepsBuilder builderFactory(AccessorFlags flags) =>
                new SourceCodeStepsBuilder(AccessorFlags.Indexer | flags, indexer.IndexerType);
            if (indexer.GetAccessor != null)
            {
                Steps.Add(new WriteChildNode<TAccessor>(indexer.GetAccessor, builderFactory(AccessorFlags.Get)));
            }

            if (indexer.SetAccessor != null)
            {
                Steps.Add(new WriteChildNode<TAccessor>(indexer.SetAccessor, builderFactory(AccessorFlags.Set)));
            }

            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Steps.AddChildNodeStepsOnNewLines(@interface.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginTypeDefinition);
            Steps.AddTypeVisibilityModifierSteps(@interface.Visibility);
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteInterfaceKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@interface.Name));
            Steps.AddGenericParameterDeclarationSteps(@interface.GenericParameters);
            if (@interface.Interfaces.Count != 0)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteColon());
                Steps.AddPlaceholder(SourceCodePlaceholder.BeginBaseTypeList);
                Steps.Add(new WriteWhitespace());
                Steps.AddCommaSeparatedChildNodeSteps(@interface.Interfaces);
                Steps.AddPlaceholder(SourceCodePlaceholder.EndBaseTypeList);
            }

            Steps.AddPlaceholder(SourceCodePlaceholder.EndTypeDefinition);
            Steps.AddGenericParameterConstraintSteps(@interface.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.AddInterfaceBodySteps(@interface);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            Steps.Add(new WriteName(interfaceReference.Name));
            Steps.AddGenericParameterSteps(interfaceReference.GenericParameters);
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            if (loadedDocument.UsingDirectives.Count != 0)
            {
                Steps.AddChildNodeStepsOnNewLines(loadedDocument.UsingDirectives);
                Steps.Add(new WriteIndentedNewLine());
            }

            if (loadedDocument.AssemblyAttributes.Count != 0 || loadedDocument.ModuleAttributes.Count != 0)
            {
                Steps.AddChildNodeStepsOnNewLines(loadedDocument.AssemblyAttributes);
                Steps.AddChildNodeStepsOnNewLines(loadedDocument.ModuleAttributes);
                Steps.Add(new WriteIndentedNewLine());
            }

            List<ISourceCodeBuilderStep> steps = new List<ISourceCodeBuilderStep>();
            steps.AddRange(loadedDocument.Enums.ToSteps());
            steps.AddRange(loadedDocument.Delegates.ToSteps());
            steps.AddRange(loadedDocument.Interfaces.ToSteps());
            steps.AddIfNotEmpty(loadedDocument.Structs);
            steps.AddIfNotEmpty(loadedDocument.Classes);
            steps.AddRange(loadedDocument.Namespaces.ToSteps());
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddReturnAttributeNodeSteps(method.ReturnAttributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            Steps.AddClassMemberVisibilityModifierSteps(method.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(method.InheritanceModifier);
            VisitMethod(method);
        }

        public override void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            explicitInterface = new WriteChildNode<TInterfaceReference>(method.ExplicitInterface);
            VisitMethod(method);
            explicitInterface = null;
        }

        public override void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddChildNodeStepsOnNewLines(method.ReturnAttributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            Steps.AddInterfaceMemberInheritanceModifierSteps(method.InheritanceModifier);
            Steps.Add(new WriteChildNode<TTypeReference>(method.ReturnType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(method.Name));
            Steps.AddGenericParameterDeclarationSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodParametersDefinition);
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndMethodParametersDefinition);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddPlaceholder(SourceCodePlaceholder.EndMethodDefinition);
            Steps.AddGenericParameterConstraintSteps(method.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddReturnAttributeNodeSteps(method.ReturnAttributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            Steps.AddStructMemberVisibilityModifierSteps(method.Visibility);
            Steps.AddStructMemberInheritanceModifierSteps(method.InheritanceModifier);
            VisitMethod(method);
        }

        public override void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddReturnAttributeNodeSteps(method.ReturnAttributes);
            Steps.Add(new WriteChildNode<TTypeReference>(method.ReturnType));
            Steps.Add(new WriteWhitespace());
            if (explicitInterface != null)
            {
                Steps.Add(explicitInterface);
                Steps.Add(new WriteDot());
            }

            Steps.Add(new WriteName(method.Name));
            Steps.AddGenericParameterDeclarationSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(method.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(method.ReturnType));
            Steps.Add(new WriteWhitespace());
            if (explicitInterface != null)
            {
                Steps.Add(explicitInterface);
                Steps.Add(new WriteDot());
            }

            Steps.Add(new WriteName(method.Name));
            Steps.AddGenericParameterDeclarationSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodParametersDefinition);
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndMethodParametersDefinition);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddPlaceholder(SourceCodePlaceholder.EndMethodDefinition);
            Steps.AddGenericParameterConstraintSteps(method.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (method.Body != null)
            {
                Steps.Add(new WriteChildNode<TMethodBody>(method.Body));
            }

            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody)
        {
            if (methodBody.Statements.Count == 0 || !(methodBody.Statements[0] is IStatement))
            {
                if (!string.IsNullOrWhiteSpace(emptyBodyText))
                {
                    Steps.Add(new WriteEmptyBody(emptyBodyText));
                }
            }
            else
            {
                foreach (TStatement statement in methodBody.Statements)
                {
                    Steps.Add(new WriteIndentedNewLine());
                    Steps.Add(new WriteGenericStatement<TStatement>(statement));
                }
            }
        }

        public override void VisitNamedAttributeValue<TExpression>(INamedAttributeValue<TExpression> namedAttributeValue)
        {
            Steps.Add(new WriteName(namedAttributeValue.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEquals());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(namedAttributeValue.Value));
        }
        
        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            Steps.Add(new WriteNamespaceKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@namespace.Name));
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.AddChildNodeStepsOnNewLines(@namespace.UsingDirectives, NewLineLocation.BeforeNode);
            List<ISourceCodeBuilderStep> steps = new List<ISourceCodeBuilderStep>();
            steps.AddRange(@namespace.Enums.ToSteps());
            steps.AddRange(@namespace.Delegates.ToSteps());
            steps.AddRange(@namespace.Interfaces.ToSteps());
            steps.AddIfNotEmpty(@namespace.Structs);
            steps.AddIfNotEmpty(@namespace.Classes);
            steps.AddRange(@namespace.Namespaces.ToSteps());
            if (steps.Count != 0)
            {
                if (@namespace.UsingDirectives.Count != 0)
                {
                    Steps.Add(new WriteNewLine());
                }

                Steps.Add(new WriteIndentedNewLine());
                Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
            }

            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedClass(nestedClass);
        }

        public override void VisitStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedAbstractClass(nestedClass);
        }

        public override void VisitStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedStruct.Visibility);
            base.VisitStructNestedSealedClass(nestedStruct);
        }

        public override void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedStaticClass(nestedClass);
        }

        public override void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedClass(nestedClass);
        }

        public override void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedClass.Name));
            Steps.AddGenericParameterDeclarationSteps(nestedClass.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(nestedClass, nestedClass);
            Steps.AddGenericParameterConstraintSteps(nestedClass.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (nestedClass.Destructor != null)
            {
                destructorStep = new ISourceCodeBuilderStep[]
                {
                    new WriteChildNode<TDestructor>(nestedClass.Destructor)
                };
            }

            VisitType(nestedClass);
            destructorStep = new ISourceCodeBuilderStep[0];
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
        {
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterDeclarationSteps(@class.GenericParameters);
            Steps.AddGenericParameterConstraintSteps(@class.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            VisitStaticType(@class);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedStaticClass(nestedClass);
        }

        public override void VisitNullableTypeReference<TStructReference>(
            INullableTypeReference<TStructReference> reference)
        {
            reference.Type.Accept(this);
            Steps.Add(new WriteQuestionMark());
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedDelegate.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedDelegate.Visibility);
            VisitNestedDelegate(nestedDelegate);
        }

        public override void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedDelegate.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedDelegate.Visibility);
            VisitNestedDelegate(nestedDelegate);
        }

        public override void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Steps.Add(new WriteDelegateKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(nestedDelegate.ReturnType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedDelegate.Name));
            Steps.AddGenericParameterDeclarationSteps(nestedDelegate.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(nestedDelegate.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(nestedDelegate.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }
        
        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedEnum.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedEnum.Visibility);
            VisitNestedEnum(nestedEnum);
        }

        public override void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedEnum.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedEnum.Visibility);
            VisitNestedEnum(nestedEnum);
        }

        public override void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Steps.Add(new WriteEnumKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedEnum.Name));
            if (nestedEnum.BaseType != EnumBaseType.None)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteColon());
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteEnumBaseType(nestedEnum.BaseType));
            }

            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.AddChildNodeSteps(nestedEnum.EnumMembers, () => Steps.AddRange(new WriteComma(), new WriteIndentedNewLine()));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedEnumMember.Attributes);
            Steps.Add(new WriteName(nestedEnumMember.Name));
        }

        public override void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Steps.AddChildNodeStepsOnNewLines(@interface.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(@interface.Visibility);
            VisitNestedInterface(@interface);
        }

        public override void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Steps.AddChildNodeStepsOnNewLines(@interface.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(@interface.Visibility);
            VisitNestedInterface(@interface);
        }

        public override void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteInterfaceKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@interface.Name));
            Steps.AddGenericParameterDeclarationSteps(@interface.GenericParameters);
            if (@interface.Interfaces.Count != 0)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteColon());
                Steps.Add(new WriteWhitespace());
                Steps.AddCommaSeparatedChildNodeSteps(@interface.Interfaces);
            }

            Steps.AddGenericParameterConstraintSteps(@interface.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.AddInterfaceBodySteps(@interface);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedStruct.Visibility);
            VisitNestedStruct(nestedStruct);
        }

        public override void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedStruct.Visibility);
            VisitNestedStruct(nestedStruct);
        }

        public override void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteStructKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedStruct.Name));
            Steps.AddGenericParameterDeclarationSteps(nestedStruct.GenericParameters);
            Steps.AddImplementedInterfacesSteps(nestedStruct);
            Steps.AddGenericParameterConstraintSteps(nestedStruct.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            VisitType(nestedStruct);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }
        
        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(nestedTypeReference.Type));
            Steps.Add(new WriteDot());
            Steps.Add(new WriteChildNode<TTypeReference>(nestedTypeReference.NestedType));
        }

        public override void VisitOperatorParameter<TAttributeGroup, TTypeReference>(
            IOperatorParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            Steps.AddChildNodeStepsOnNewLines(operatorOverload.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(ClassMemberVisibilityModifier.Public);
            Steps.AddClassMemberInheritanceModifierSteps(ClassMemberInheritanceModifier.Static);
            Steps.Add(new WriteChildNode<TTypeReference>(operatorOverload.ReturnType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteOperatorKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteOperatorOverloadType(operatorOverload.OperatorType));
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(operatorOverload.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteChildNode<TMethodBody>(operatorOverload.Body));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitConstructorParameter<TAttributeGroup, TTypeReference>(
            IConstructorParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            Steps.AddMethodParameterModifierSteps(parameter.Modifier);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitDelegateParameter<TAttributeGroup, TTypeReference>(
            IDelegateParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            Steps.AddMethodParameterModifierSteps(parameter.Modifier);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitExtensionParameter<TAttributeGroup, TTypeReference>(
            IExtensionParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            Steps.Add(new WriteThisKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitIndexerParameter<TAttributeGroup, TTypeReference>(
            IIndexerParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            if (parameter.Modifier == IndexerParameterModifier.Params)
            {
                Steps.Add(new WriteMethodParameterModifier(ParameterModifier.Params));
                Steps.Add(new WriteWhitespace());
            }

            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitMethodParameter<TAttributeGroup, TTypeReference>(
            IMethodParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            Steps.AddMethodParameterModifierSteps(parameter.Modifier);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddAbstractMemberVisibilityModifierSteps(property.Visibility);
            Steps.Add(new WriteAbstractKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(property.PropertyType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(property.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            if (property.GetAccessor != null)
            {
                Steps.Add(new WriteChildNode<TAccessor>(property.GetAccessor));
            }

            if (property.SetAccessor != null)
            {
                if (property.GetAccessor != null)
                {
                    Steps.Add(new WriteWhitespace());
                }

                Steps.Add(new WriteChildNode<TAccessor>(property.SetAccessor));
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitProperty(property);
        }

        public override void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            explicitInterface = new WriteChildNode<TInterfaceReference>(property.ExplicitInterface);
            VisitProperty(property);
            explicitInterface = null;
        }

        public override void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddInterfaceMemberInheritanceModifierSteps(property.InheritanceModifier);
            Steps.Add(new WriteChildNode<TTypeReference>(property.PropertyType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(property.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            if (property.GetAccessor != null)
            {
                Steps.Add(new WriteGetKeyword());
                Steps.Add(new WriteSemicolon());
            }

            if (property.SetAccessor != null)
            {
                if (property.GetAccessor != null)
                {
                    Steps.Add(new WriteWhitespace());
                }

                Steps.Add(new WriteSetKeyword());
                Steps.Add(new WriteSemicolon());
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddStructMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitProperty(property);
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(property.PropertyType));
            Steps.Add(new WriteWhitespace());
            if (explicitInterface != null)
            {
                Steps.Add(explicitInterface);
                Steps.Add(new WriteDot());
            }

            Steps.Add(new WriteName(property.Name));
            bool containsNewLines = false;
            List<ISourceCodeBuilderStep> steps = new List<ISourceCodeBuilderStep>();
            SourceCodeStepsBuilder builderFactory(AccessorFlags flags) =>
                new SourceCodeStepsBuilder(AccessorFlags.Property | flags, property.PropertyType);
            if (property.GetAccessor != null)
            {
                WriteChildNode<TAccessor> step = new WriteChildNode<TAccessor>(
                    property.GetAccessor,
                    builderFactory(AccessorFlags.Get));
                containsNewLines = step.Steps.OfType<WriteIndentedNewLine>().Any();
                steps.Add(step);
            }

            if (property.SetAccessor != null)
            {
                WriteChildNode<TAccessor> step = new WriteChildNode<TAccessor>(
                    property.SetAccessor,
                    builderFactory(AccessorFlags.Set));
                containsNewLines &= step.Steps.OfType<WriteIndentedNewLine>().Any();
                steps.Add(step);
            }

            Steps.Add(containsNewLines ? (ISourceCodeBuilderStep)new WriteIndentedNewLine() : new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            if (containsNewLines)
            {
                Steps.Add(new IncrementIndent());
            }

            Steps.AddRange(steps);
            if (containsNewLines)
            {
                Steps.Add(new DecrementIndent());
            }

            Steps.Add(containsNewLines ? (ISourceCodeBuilderStep)new WriteIndentedNewLine() : new WriteWhitespace());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
        {
            Steps.AddChildNodeStepsOnNewLines(@struct.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginTypeDefinition);
            Steps.AddTypeVisibilityModifierSteps(@struct.Visibility);
            if (isPartial)
            {
                Steps.Add(new WritePartialKeyword());
                Steps.Add(new WriteWhitespace());
            }

            Steps.Add(new WriteStructKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@struct.Name));
            Steps.AddGenericParameterDeclarationSteps(@struct.GenericParameters);
            Steps.AddImplementedInterfacesSteps(@struct);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndTypeDefinition);
            Steps.AddGenericParameterConstraintSteps(@struct.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            VisitType(@struct);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }
        
        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            Steps.Add(new WriteName(structReference.Name));
            Steps.AddGenericParameterSteps(structReference.GenericParameters);
        }

        public override void VisitType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
        {
            List<ISourceCodeBuilderStep> typeSteps = new List<ISourceCodeBuilderStep>();
            typeSteps.AddIfNotEmpty(type.Fields);
            typeSteps.AddIfNotEmpty(type.Events);
            typeSteps.AddIfNotNull(type.StaticConstructor);
            typeSteps.AddRange(type.Constructors.ToSteps());
            typeSteps.AddRange(destructorStep);
            typeSteps.AddIfNotEmpty(type.Properties);
            typeSteps.AddIfNotEmpty(type.Indexers);
            typeSteps.AddIfNotEmpty(type.Methods);
            typeSteps.AddRange(type.ConversionOperators.ToSteps());
            typeSteps.AddRange(type.OperatorOverloads.ToSteps());
            typeSteps.AddIfNotEmpty(type.Classes);
            typeSteps.AddRange(type.Delegates.ToSteps());
            typeSteps.AddRange(type.Enums.ToSteps());
            typeSteps.AddRange(type.Interfaces.ToSteps());
            typeSteps.AddIfNotEmpty(type.Structs);
            if (typeSteps.Any())
            {
                Steps.Add(new WriteIndentedNewLine());
            }

            Steps.AddRange(typeSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> propertySteps =
                propertyCollection.ToSteps()
                .Concat(propertyCollection.AutoProperties.ToSteps())
                .Concat(propertyCollection.LambdaProperties.ToSteps())
                .Concat(propertyCollection.ExplicitInterfaceProperties.ToSteps());
            Steps.AddRange(propertySteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitSealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> propertySteps =
                propertyCollection.ToSteps()
                .Concat(propertyCollection.AutoProperties.ToSteps())
                .Concat(propertyCollection.LambdaProperties.ToSteps())
                .Concat(propertyCollection.ExplicitInterfaceProperties.ToSteps());
            Steps.AddRange(propertySteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty>(
            IStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty> propertyCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> propertySteps =
                propertyCollection.ToSteps()
                .Concat(propertyCollection.AutoProperties.ToSteps())
                .Concat(propertyCollection.LambdaProperties.ToSteps());
            Steps.AddRange(propertySteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> propertySteps =
                propertyCollection.ToSteps()
                .Concat(propertyCollection.AutoProperties.ToSteps())
                .Concat(propertyCollection.LambdaProperties.ToSteps())
                .Concat(propertyCollection.ExplicitInterfaceProperties.ToSteps());
            Steps.AddRange(propertySteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue)
        {
            Steps.Add(new WriteExpression<TExpression>(unnamedAttributeValue.Value));
        }
        
        public override void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecificTypeReference)
        {
            Steps.Add(new WriteName(unspecificTypeReference.Name));
            Steps.AddGenericParameterSteps(unspecificTypeReference.GenericParameters);
        }

        public override void VisitUsingDirective(IUsingDirective usingDirective)
        {
            Steps.Add(new WriteUsingKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(usingDirective.Name));
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
        {
            Steps.AddChildNodeStepsOnNewLines(staticConstructor.Attributes);
            Steps.Add(new WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier.Static));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(((IHasName)staticConstructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteChildNode<TMethodBody>(staticConstructor.Body));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitAbstractAccessor<TAttributeGroup>(IAbstractAccessor<TAttributeGroup> accessor)
        {
            Steps.Add(new WriteWhitespace());
            Steps.AddRange(accessor.Attributes.ToSteps());
            Steps.AddAbstractAccessorVisibilityModifierSteps(accessor.Visibility);
            Steps.Add(accessorFlags.HasFlag(AccessorFlags.Get) ? (ISourceCodeBuilderStep)new WriteGetKeyword() : new WriteSetKeyword());
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            isPartial = true;
            VisitAbstractClass(@class);
        }

        public override void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            Steps.AddChildNodeStepsOnNewLines(@class.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginTypeDefinition);
            Steps.AddTypeVisibilityModifierSteps(@class.Visibility);
            Steps.Add(new WriteAbstractKeyword());
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterDeclarationSteps(@class.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(@class, @class);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndTypeDefinition);
            Steps.AddGenericParameterConstraintSteps(@class.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (@class.Destructor != null)
            {
                destructorStep = new ISourceCodeBuilderStep[]
                {
                    new WriteChildNode<TDestructor>(@class.Destructor)
                };
            }

            VisitType(@class);
            destructorStep = new ISourceCodeBuilderStep[0];
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> steps =
                eventCollection.ToSteps()
                .Concat(eventCollection.EventProperties.ToSteps())
                .Concat(eventCollection.ExplicitInterfaceEvents.ToSteps())
                .Concat(eventCollection.AbstractEvents.ToSteps());
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> steps =
                indexerCollection.ToSteps()
                .Concat(indexerCollection.ExplicitInterfaceIndexers.ToSteps())
                .Concat(indexerCollection.AbstractIndexers.ToSteps());
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> steps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps())
                .Concat(methodCollection.AbstractMethods.ToSteps());
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> steps =
                propertyCollection.ToSteps()
                .Concat(propertyCollection.AutoProperties.ToSteps())
                .Concat(propertyCollection.LambdaProperties.ToSteps())
                .Concat(propertyCollection.ExplicitInterfaceProperties.ToSteps())
                .Concat(propertyCollection.AbstractProperties.ToSteps());
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitConstant<TExpression>(IConstant<TExpression> constant)
        {
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(constant.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEquals());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(constant.ConstantValue));
        }

        public override void VisitConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constantGroup)
        {
            Steps.Add(new WriteConstantKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(constantGroup.FieldType));
            Steps.AddCommaSeparatedChildNodeSteps(constantGroup.Constants);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant)
        {
            Steps.AddChildNodeStepsOnNewLines(classConstant.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(classConstant.Visibility);
            VisitConstantGroup(classConstant);
        }

        public override void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
        {
            Steps.AddChildNodeStepsOnNewLines(constant.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(constant.Visibility);
            VisitConstantGroup(constant);
        }

        public override void VisitClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedAbstractClass(nestedClass);
        }

        public override void VisitNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.Add(new WriteAbstractKeyword());
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedClass.Name));
            Steps.AddGenericParameterDeclarationSteps(nestedClass.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(nestedClass, nestedClass);
            Steps.AddGenericParameterConstraintSteps(nestedClass.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (nestedClass.Destructor != null)
            {
                destructorStep = new ISourceCodeBuilderStep[]
                {
                    new WriteChildNode<TDestructor>(nestedClass.Destructor)
                };
            }

            VisitType(nestedClass);
            destructorStep = new ISourceCodeBuilderStep[0];
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedSealedClass(nestedClass);
        }

        public override void VisitNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteSealed());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedClass.Name));
            Steps.AddGenericParameterDeclarationSteps(nestedClass.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(nestedClass, nestedClass);
            Steps.AddGenericParameterConstraintSteps(nestedClass.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (nestedClass.Destructor != null)
            {
                destructorStep = new ISourceCodeBuilderStep[]
                {
                    new WriteChildNode<TDestructor>(nestedClass.Destructor)
                };
            }

            VisitType(nestedClass);
            destructorStep = new ISourceCodeBuilderStep[0];
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitSealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            Steps.AddChildNodeStepsOnNewLines(@class.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginTypeDefinition);
            Steps.AddTypeVisibilityModifierSteps(@class.Visibility);
            Steps.Add(new WriteSealed());
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterDeclarationSteps(@class.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(@class, @class);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndTypeDefinition);
            Steps.AddGenericParameterConstraintSteps(@class.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            if (@class.Destructor != null)
            {
                destructorStep = new ISourceCodeBuilderStep[]
                {
                    new WriteChildNode<TDestructor>(@class.Destructor)
                };
            }

            VisitType(@class);
            destructorStep = new ISourceCodeBuilderStep[0];
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(indexer.Visibility);
            Steps.AddSealedClassIndexerInheritanceModifierSteps(indexer.InheritanceModifier);
            VisitIndexer(indexer);
        }

        public override void VisitSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddReturnAttributeNodeSteps(method.ReturnAttributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            Steps.AddClassMemberVisibilityModifierSteps(method.Visibility);
            Steps.AddSealedClassMemberInheritanceModifierSteps(method.InheritanceModifier);
            VisitMethod(method);
        }

        public override void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddSealedClassMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitProperty(property);
        }

        public override void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
        {
            Steps.AddChildNodeStepsOnNewLines(@class.Attributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginTypeDefinition);
            Steps.AddTypeVisibilityModifierSteps(@class.Visibility);
            Steps.Add(new WriteStatic());
            if (isPartial)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WritePartialKeyword());
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterDeclarationSteps(@class.GenericParameters);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndTypeDefinition);
            Steps.AddGenericParameterConstraintSteps(@class.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            VisitStaticType(@class);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
        {
            Steps.AddChildNodeStepsOnNewLines(constant.Attributes);
            Steps.AddStaticClassMemberVisibilityModifierSteps(constant.Visibility);
            VisitConstantGroup(constant);
        }

        public override void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(
            IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            accessorVisibilityAction = () => Steps.AddStaticClassAccessorVisibilityModifierSteps(accessor.Visibility);
            VisitAccessor(accessor);
        }

        public override void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddChildNodeStepsOnNewLines(@event.Attributes);
            Steps.AddStaticClassMemberVisibilityModifierSteps(@event.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            VisitEvent(@event);
        }

        public override void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Steps.AddChildNodeStepsOnNewLines(eventProperty.Attributes);
            Steps.AddStaticClassMemberVisibilityModifierSteps(eventProperty.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            VisitEventProperty(eventProperty);
        }

        public override void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Steps.AddStaticClassMemberVisibilityModifierSteps(field.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            Steps.AddStaticClassFieldModifierSteps(field.Modifier);
            VisitFieldGroup(field);
        }

        public override void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddReturnAttributeNodeSteps(method.ReturnAttributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            Steps.AddStaticClassMemberVisibilityModifierSteps(method.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            VisitMethod(method);
        }

        public override void VisitStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedAbstractClass(nestedClass);
        }

        public override void VisitStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStaticClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedStaticClass.Visibility);
            VisitNestedClass(nestedStaticClass);
        }

        public override void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedDelegate.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedDelegate.Visibility);
            VisitNestedDelegate(nestedDelegate);
        }

        public override void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedEnum.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedEnum.Visibility);
            VisitNestedEnum(nestedEnum);
        }

        public override void VisitStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Steps.AddChildNodeStepsOnNewLines(@interface.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(@interface.Visibility);
            VisitNestedInterface(@interface);
        }

        public override void VisitStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedSealedClass(nestedClass);
        }

        public override void VisitStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedStaticClass(nestedClass);
        }

        public override void VisitStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedStruct.Visibility);
            VisitNestedStruct(nestedStruct);
        }

        public override void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddStaticClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            VisitProperty(property);
        }

        public override void VisitStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
        {
            List<ISourceCodeBuilderStep> typeSteps = new List<ISourceCodeBuilderStep>();
            typeSteps.AddIfNotEmpty(type.Fields);
            typeSteps.AddIfNotEmpty(type.Events);
            typeSteps.AddIfNotNull(type.StaticConstructor);
            typeSteps.AddIfNotEmpty(type.Properties);
            typeSteps.AddIfNotEmpty(type.Methods);
            typeSteps.AddIfNotEmpty(type.Classes);
            typeSteps.AddRange(type.Delegates.ToSteps());
            typeSteps.AddRange(type.Enums.ToSteps());
            typeSteps.AddRange(type.Interfaces.ToSteps());
            typeSteps.AddIfNotEmpty(type.Structs);
            if (typeSteps.Any())
            {
                Steps.Add(new WriteIndentedNewLine());
            }

            Steps.AddRange(typeSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
        {
            List<ISourceCodeBuilderStep> methodSteps = new List<ISourceCodeBuilderStep>();
            methodSteps.AddRange(methodCollection.ExtensionMethods.ToSteps());
            methodSteps.AddRange(methodCollection.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            VisitProperty(property);
            if (property.InitialValue != null)
            {
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteEquals());
                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteExpression<TExpression>(property.InitialValue));
            }
        }

        public override void VisitClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitAutoProperty(property);
        }

        public override void VisitSealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            ISealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddSealedClassMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitAutoProperty(property);
        }

        public override void VisitStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddStaticClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            VisitAutoProperty(property);
        }

        public override void VisitStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddStructMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitAutoProperty(property);
        }

        public override void VisitLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(property.PropertyType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(property.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEqualsGreaterThan());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteExpression<TExpression>(property.LambdaExpression));
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitLambdaProperty(property);
        }

        public override void VisitSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            ISealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddSealedClassMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitLambdaProperty(property);
        }

        public override void VisitStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddStaticClassMemberVisibilityModifierSteps(property.Visibility);
            Steps.Add(new WriteStatic());
            Steps.Add(new WriteWhitespace());
            VisitLambdaProperty(property);
        }

        public override void VisitStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddStructMemberInheritanceModifierSteps(property.InheritanceModifier);
            VisitLambdaProperty(property);
        }

        public override void VisitAutoPropertyAccessor<TAttributeGroup>(IAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            VisitAccessor(new AutoPropertyAccessor<TAttributeGroup>(accessor));
        }

        public override void VisitPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>(
            IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddChildNodeStepsOnNewLines(method.ReturnAttributes);
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodDefinition);
            Steps.Add(new WritePartialKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteBuiltInType(BuiltInType.Void));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(method.Name));
            Steps.AddGenericParameterDeclarationSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddPlaceholder(SourceCodePlaceholder.BeginMethodParametersDefinition);
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.AddPlaceholder(SourceCodePlaceholder.EndMethodParametersDefinition);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddPlaceholder(SourceCodePlaceholder.EndMethodDefinition);
            Steps.AddGenericParameterConstraintSteps(method.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(
            IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddChildNodeStepsOnNewLines(method.ReturnAttributes);
            Steps.Add(new WritePartialKeyword());
            Steps.Add(new WriteWhitespace());
            VisitMethod(new PartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(method));
        }

        public override void VisitAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.AbstractMethods.ToSteps())
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps())
                .Concat(methodCollection.PartialMethodDefinitions.ToSteps())
                .Concat(methodCollection.PartialMethodImplementations.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> classSteps =
                classCollection.ToSteps()
                .Concat(classCollection.AbstractClasses.ToSteps())
                .Concat(classCollection.SealedClasses.ToSteps())
                .Concat(classCollection.StaticClasses.ToSteps())
                .Concat(ToChildSteps(classCollection.PartialClasses));
            Steps.AddRange(classSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassAutoPropertyAccessor<TAttributeGroup>(
            IClassAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            accessorVisibilityAction = () => Steps.AddClassAccessorVisibilityModifierSteps(accessor.Visibility);
            VisitAutoPropertyAccessor(accessor);
        }

        public override void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> eventSteps =
                eventCollection.ToSteps()
                .Concat(eventCollection.EventProperties.ToSteps())
                .Concat(eventCollection.ExplicitInterfaceEvents.ToSteps());
            Steps.AddRange(eventSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> eventSteps =
                eventCollection.ToSteps()
                .Concat(eventCollection.EventProperties.ToSteps())
                .Concat(eventCollection.ExplicitInterfaceEvents.ToSteps());
            Steps.AddRange(eventSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> eventSteps =
                eventCollection.ToSteps()
                .Concat(eventCollection.EventProperties.ToSteps());
            Steps.AddRange(eventSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassFieldCollection<TField, TConstant>(
            IClassFieldCollection<TField, TConstant> fieldCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> fieldSteps =
                fieldCollection.ToSteps()
                .Concat(fieldCollection.Constants.ToSteps());
            Steps.AddRange(fieldSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructFieldCollection<TFieldGroup, TConstantGroup>(
            IStructFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> fieldSteps =
                fieldCollection.ToSteps()
                .Concat(fieldCollection.Constants.ToSteps());
            Steps.AddRange(fieldSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStaticClassFieldCollection<TFieldGroup, TConstantGroup>(
            IStaticClassFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> fieldSteps =
                fieldCollection.ToSteps()
                .Concat(fieldCollection.Constants.ToSteps());
            Steps.AddRange(fieldSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> indexerSteps =
                indexerCollection.ToSteps()
                .Concat(indexerCollection.ExplicitInterfaceIndexers.ToSteps());
            Steps.AddRange(indexerSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> indexerSteps =
                indexerCollection.ToSteps()
                .Concat(indexerCollection.ExplicitInterfaceIndexers.ToSteps());
            Steps.AddRange(indexerSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitStaticClassNestedAbstractClass(nestedClass);
        }

        public override void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> eventSteps =
                eventCollection.ToSteps()
                .Concat(eventCollection.EventProperties.ToSteps())
                .Concat(eventCollection.ExplicitInterfaceEvents.ToSteps());
            Steps.AddRange(eventSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> indexerSteps =
                indexerCollection.ToSteps()
                .Concat(indexerCollection.ExplicitInterfaceIndexers.ToSteps());
            Steps.AddRange(indexerSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitClassNestedAbstractClass(nestedClass);
        }

        public override void VisitNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> classSteps =
                classCollection.ToSteps()
                .Concat(classCollection.AbstractClasses.ToSteps())
                .Concat(classCollection.SealedClasses.ToSteps())
                .Concat(classCollection.StaticClasses.ToSteps())
                .Concat(ToChildSteps(classCollection.PartialClasses));
            Steps.AddRange(classSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            VisitNestedClassCollection(classCollection);
        }

        public override void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            VisitNestedClassCollection(classCollection);
        }

        public override void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            VisitNestedClassCollection(classCollection);
        }

        public override void VisitPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>(
            IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> classes)
        {
            IEnumerable<ISourceCodeBuilderStep> classSteps =
                classes.Classes.ToSteps()
                .Concat(classes.AbstractClasses.ToSteps())
                .Concat(classes.SealedClasses.ToSteps())
                .Concat(classes.StaticClasses.ToSteps());
            Steps.AddRange(classSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
        {
            isPartial = true;
            VisitStructNestedSealedClass(nestedStruct);
        }

        public override void VisitStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            isPartial = true;
            VisitStructNestedStaticClass(nestedClass);
        }

        public override void VisitStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
        {
            isPartial = true;
            VisitStaticClassNestedClass(nestedStaticClass);
        }

        public override void VisitStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            isPartial = true;
            VisitStaticClassNestedStruct(nestedStruct);
        }

        public override void VisitStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitStaticClassNestedSealedClass(nestedClass);
        }

        public override void VisitStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            isPartial = true;
            VisitStaticClassNestedStaticClass(nestedClass);
        }

        public override void VisitClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitClassNestedClass(nestedClass);
        }

        public override void VisitClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            isPartial = true;
            VisitClassNestedStruct(nestedStruct);
        }

        public override void VisitClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitClassNestedSealedClass(nestedClass);
        }

        public override void VisitClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            isPartial = true;
            VisitClassNestedStaticClass(nestedClass);
        }

        public override void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Steps.AddRange(
                structCollection.ToSteps().Concat(structCollection.PartialStructs.ToSteps()),
                () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructCollection<TStruct, TPartialStruct>(
            IStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Steps.AddRange(
                structCollection.ToSteps().Concat(structCollection.PartialStructs.ToSteps()),
                () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitNestedStructCollection<TStruct, TPartialStruct>(
            INestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Steps.AddRange(
                structCollection.ToSteps().Concat(structCollection.PartialStructs.ToSteps()),
                () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitStructNestedAbstractClass(nestedClass);
        }

        public override void VisitStructNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
        {
            isPartial = true;
            VisitStructNestedClass(nestedClass);
        }

        public override void VisitStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            isPartial = true;
            VisitStructNestedStruct(nestedStruct);
        }

        public override void VisitAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
        {
            VisitType(type);
        }

        public override void VisitClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            VisitType(@class);
        }

        public override void VisitNestedStaticClassMethodCollection<TMethod>(
            INestedStaticClassMethodCollection<TMethod> methodCollection)
        {
            Steps.AddRange(
                methodCollection.ToSteps(),
                () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitNestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.PartialMethodDefinitions.ToSteps())
                .Concat(methodCollection.PartialMethodImplementations.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps())
                .Concat(methodCollection.PartialMethodDefinitions.ToSteps())
                .Concat(methodCollection.PartialMethodImplementations.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps())
                .Concat(methodCollection.PartialMethodDefinitions.ToSteps())
                .Concat(methodCollection.PartialMethodImplementations.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitSealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            ISealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExplicitInterfaceMethods.ToSteps())
                .Concat(methodCollection.PartialMethodDefinitions.ToSteps())
                .Concat(methodCollection.PartialMethodImplementations.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
        {
            IEnumerable<ISourceCodeBuilderStep> methodSteps =
                methodCollection.ToSteps()
                .Concat(methodCollection.ExtensionMethods.ToSteps())
                .Concat(methodCollection.PartialMethodDefinitions.ToSteps())
                .Concat(methodCollection.PartialMethodImplementations.ToSteps());
            Steps.AddRange(methodSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitSealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            ISealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
        {
            VisitType(type);
        }

        public override void VisitStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
        {
            VisitType(type);
        }

        public override void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Steps.AddRange(
                structCollection.ToSteps().Concat(structCollection.PartialStructs.ToSteps()),
                () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            Steps.AddRange(
                structCollection.ToSteps().Concat(structCollection.PartialStructs.ToSteps()),
                () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
        {
            throw new NotImplementedException();
        }

        public override void VisitSealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            ISealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            isPartial = true;
            VisitSealedClass(@class);
        }

        public override void VisitStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
        {
            isPartial = true;
            VisitStaticClass(@class);
        }

        public override void VisitPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            isPartial = true;
            VisitClass(@class);
        }

        public override void VisitPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
        {
            isPartial = true;
            VisitStruct(@struct);
        }

        public override void VisitStaticClassAutoPropertyAccessor<TAttributeGroup>(
            IStaticClassAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            accessorVisibilityAction = () => Steps.AddStaticClassAccessorVisibilityModifierSteps(accessor.Visibility);
            VisitAutoPropertyAccessor(accessor);
        }

        public override void VisitStructAutoPropertyAccessor<TAttributeGroup>(
            IStructAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            accessorVisibilityAction = () => Steps.AddStructAccessorVisibilityModifierSteps(accessor.Visibility);
            VisitAutoPropertyAccessor(accessor);
        }

        private static IEnumerable<ISourceCodeBuilderStep> ToChildSteps<T>(T child)
            where T : IVisitable<IGenericVisitor>
        {
            if (child == null)
            {
                return Enumerable.Empty<ISourceCodeBuilderStep>();
            }

            WriteChildNode<T> childNode = new WriteChildNode<T>(child);
            return childNode.Steps.Count == 0 ?
                Enumerable.Empty<ISourceCodeBuilderStep>() :
                new ISourceCodeBuilderStep[] { childNode };
        }
    }
}
