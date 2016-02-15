using CSharpDom.BaseClasses;
using CSharpDom.Common;
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

        public override void VisitClassAccessor<TAttributeGroup, TMethodBody>(
            IClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
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
            VisitAccessor(accessor);
        }

        public override void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            bool isIndexer = accessorFlags.HasFlag(AccessorFlags.Indexer);
            Steps.Add(isIndexer ? (ISourceCodeBuilderStep)new WriteIndentedNewLine() : new WriteWhitespace());
            Steps.AddRange(accessor.Attributes.Select(attribute => new WriteChildNode<TAttributeGroup>(attribute)));
            Steps.Add(accessorFlags.HasFlag(AccessorFlags.Get) ? (ISourceCodeBuilderStep)new WriteGetKeyword() : new WriteSetKeyword());
            if (isIndexer)
            {
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

                if (methodBody.Steps.Count == 0)
                {
                    Steps.Add(new WriteWhitespace());
                    Steps.Add(new WriteStartBrace());
                    Steps.Add(new WriteWhitespace());
                    Steps.Add(new WriteEndBrace());
                }       
                else if (methodBody.Steps.OfType<WriteIndentedNewLine>().Any())
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
                    Steps.Add(new WriteWhitespace());
                    Steps.Add(new WriteStartBrace());
                    Steps.Add(new WriteWhitespace());
                    Steps.Add(methodBody);
                    Steps.Add(new WriteWhitespace());
                    Steps.Add(new WriteEndBrace());
                }
            }
            else
            {
                Steps.Add(new WriteSemicolon());
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
            Steps.AddCommaSeparatedChildNodeSteps(attributes.Attributes);
            Steps.Add(new WriteEndBracket());
        }


        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
        {
            Steps.AddChildNodeStepsOnNewLines(@class.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@class.Visibility);
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterSteps(@class.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(@class, @class);
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
            Steps.AddGenericParameterSteps(@delegate.GenericParameters);
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

        public override void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddClassMemberVisibilityModifierSteps(@event.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(@event.InheritanceModifier);
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
            Steps.AddStructMemberVisibilityModifierSteps(@event.Visibility);
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
            Steps.AddClassMemberVisibilityModifierSteps(eventProperty.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(eventProperty.InheritanceModifier);
            VisitEventProperty(eventProperty);
        }

        public override void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
        {
            explicitInterface = new WriteChildNode<TInterfaceReference>(@event.ExplicitInterface);
            VisitEventProperty(@event);
            explicitInterface = null;
        }

        public override void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Steps.AddStructMemberVisibilityModifierSteps(eventProperty.Visibility);
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
            Steps.Add(new WriteAddKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TMethodBody>(eventProperty.AddBody));
            Steps.Add(new WriteEndBrace());
            Steps.Add(new WriteIndentedNewLine());
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

        public override void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(genericParameter.Type));
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
            explicitInterface = new WriteChildNode<TInterfaceReference>(indexer.ExplicitInterface);
            VisitIndexer(indexer);
            explicitInterface = null;
        }

        public override void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
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
            Func<AccessorFlags, SourceCodeStepsBuilder> builderFactory =
                flags => new SourceCodeStepsBuilder(AccessorFlags.Indexer | flags, indexer.IndexerType);
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
            Steps.AddTypeVisibilityModifierSteps(@interface.Visibility);
            Steps.Add(new WriteInterfaceKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@interface.Name));
            Steps.AddGenericParameterSteps(@interface.GenericParameters);
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

            IEnumerable<ISourceCodeBuilderStep> steps =
                loadedDocument.Enums.Select(@enum => (ISourceCodeBuilderStep)new WriteChildNode<TEnum>(@enum))
                .Concat(loadedDocument.Delegates.Select(@delegate => new WriteChildNode<TDelegate>(@delegate)))
                /*.Concat(loadedDocument.Interfaces.Select(@interface => new WriteChildNode<TInterface>(@interface)))
                .Concat(loadedDocument.Structs.Select(@struct => new WriteChildNode<TStruct>(@struct)))
                .Concat(loadedDocument.Classes.Select(@class => new WriteChildNode<TClass>(@class)))*/
                .Concat(loadedDocument.Namespaces.Select(@namespace => new WriteChildNode<TNamespace>(@namespace)));
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(method.Visibility);
            Steps.AddClassMemberInheritanceModifierSteps(method.InheritanceModifier);
            VisitMethod(method);
        }

        public override void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            explicitInterface = new WriteChildNode<TInterfaceReference>(method.ExplicitInterface);
            VisitMethod(method);
            explicitInterface = null;
        }

        public override void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Steps.Add(new WriteChildNode<TTypeReference>(method.ReturnType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(method.Name));
            Steps.AddGenericParameterSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(method.GenericParameters);
        }

        public override void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(method.Visibility);
            VisitMethod(method);
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
            Steps.AddGenericParameterSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.Add(new WriteEndParenthesis());
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
            ISourceCodeBuilderStep[] steps =
                @namespace.Enums.Select(@enum => (ISourceCodeBuilderStep)new WriteChildNode<TEnum>(@enum))
                .Concat(@namespace.Delegates.Select(@delegate => new WriteChildNode<TDelegate>(@delegate)))
                /*.Concat(@namespace.Interfaces.Select(@interface => new WriteChildNode<TInterface>(@interface)))
                .Concat(@namespace.Structs.Select(@struct => new WriteChildNode<TStruct>(@struct)))
                .Concat(@namespace.Classes.Select(@class => new WriteChildNode<TClass>(@class)))*/
                .Concat(@namespace.Namespaces.Select(inner => new WriteChildNode<TNamespace>(inner)))
                .ToArray();
            if (steps.Length != 0)
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

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedClass(nestedClass);
        }

        public override void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedClass.Visibility);
            VisitNestedClass(nestedClass);
        }

        public override void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
        {
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedClass.Name));
            Steps.AddGenericParameterSteps(nestedClass.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(nestedClass, nestedClass);
            Steps.AddGenericParameterConstraintSteps(nestedClass.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            VisitType(nestedClass);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
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
            Steps.AddGenericParameterSteps(nestedDelegate.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(nestedDelegate.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(nestedDelegate.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedDestructor.Attributes);
            Steps.Add(new WriteTilda());
            Steps.Add(new WriteName(((IHasName)nestedDestructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteChildNode<TMethodBody>(nestedDestructor.Body));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
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
            Steps.Add(new WriteInterfaceKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@interface.Name));
            Steps.AddGenericParameterSteps(@interface.GenericParameters);
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

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddClassMemberVisibilityModifierSteps(nestedStruct.Visibility);
            VisitNestedStruct(nestedStruct);
        }

        public override void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddStructMemberVisibilityModifierSteps(nestedStruct.Visibility);
            VisitNestedStruct(nestedStruct);
        }

        public override void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Steps.Add(new WriteStructKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedStruct.Name));
            Steps.AddGenericParameterSteps(nestedStruct.GenericParameters);
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

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeSteps(parameter.Attributes);
            //Steps.AddMethodParameterModifierSteps(parameter.Modifier);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
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
            explicitInterface = new WriteChildNode<TInterfaceReference>(property.ExplicitInterface);
            VisitProperty(property);
            explicitInterface = null;
        }

        public override void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
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
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Func<AccessorFlags, SourceCodeStepsBuilder> builderFactory =
                flags => new SourceCodeStepsBuilder(AccessorFlags.Property | flags, property.PropertyType);
            if (property.GetAccessor != null)
            {
                Steps.Add(new WriteChildNode<TAccessor>(property.GetAccessor, builderFactory(AccessorFlags.Get)));
            }

            if (property.SetAccessor != null)
            {
                Steps.Add(new WriteChildNode<TAccessor>(property.SetAccessor, builderFactory(AccessorFlags.Set)));
            }

            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @struct)
        {
            Steps.AddChildNodeStepsOnNewLines(@struct.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@struct.Visibility);
            Steps.Add(new WriteStructKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@struct.Name));
            Steps.AddGenericParameterSteps(@struct.GenericParameters);
            Steps.AddImplementedInterfacesSteps(@struct);
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

        public override void VisitType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type)
        {
            /*ISourceCodeBuilderStep[] typeSteps =
                type.Fields.Select(field => (ISourceCodeBuilderStep)new WriteChildNode<TField>(field))
                .Concat(type.Events.Select(@event => new WriteChildNode<TEvent>(@event)))
                .Concat(type.EventProperties.Select(eventProperty => new WriteChildNode<TEventProperty>(eventProperty)))
                .Concat(type.ExplicitInterfaceEvents.Select(@event => new WriteChildNode<TExplicitInterfaceEvent>(@event)))
                .ConcatIfNotNull(type.StaticConstructor, constructor => new WriteChildNode<TStaticConstructor>(constructor))
                .Concat(type.Constructors.Select(constructor => new WriteChildNode<TConstructor>(constructor)))
                .Concat(destructorStep)
                .Concat(type.Properties.Select(property => new WriteChildNode<TProperty>(property)))
                .Concat(type.ExplicitInterfaceProperties.Select(property => new WriteChildNode<TExplicitInterfaceProperty>(property)))
                .Concat(type.Indexers.Select(indexer => new WriteChildNode<TIndexer>(indexer)))
                .Concat(type.ExplicitInterfaceIndexers.Select(indexer => new WriteChildNode<TExplicitInterfaceIndexer>(indexer)))
                .Concat(type.Methods.Select(method => new WriteChildNode<TMethod>(method)))
                .Concat(type.ExplicitInterfaceMethods.Select(method => new WriteChildNode<TExplicitInterfaceMethod>(method)))
                .Concat(type.OperatorOverloads.Select(@operator => new WriteChildNode<TOperatorOverload>(@operator)))
                .Concat(type.ConversionOperators.Select(@operator => new WriteChildNode<TConversionOperator>(@operator)))
                .Concat(type.Classes.Select(@class => new WriteChildNode<TNestedClass>(@class)))
                .Concat(type.Delegates.Select(@delegate => new WriteChildNode<TNestedDelegate>(@delegate)))
                .Concat(type.Enums.Select(@enum => new WriteChildNode<TNestedEnum>(@enum)))
                .Concat(type.Interfaces.Select(@interface => new WriteChildNode<TNestedInterface>(@interface)))
                .Concat(type.Structs.Select(@struct => new WriteChildNode<TNestedStruct>(@struct)))
                .ToArray();
            if (typeSteps.Any())
            {
                Steps.Add(new WriteIndentedNewLine());
            }

            Steps.AddRange(typeSteps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));*/
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
    }
}
