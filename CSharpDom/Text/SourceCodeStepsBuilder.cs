using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Text.Steps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Text
{
    public sealed class SourceCodeStepsBuilder : AbstractGenericVisitor
    {
        private readonly bool isInInterface;
        private readonly AccessorFlags accessorFlags;
        private readonly ITypeReference accessorType;

        public SourceCodeStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }
        
        internal SourceCodeStepsBuilder(
            bool isInInterface,
            AccessorFlags accessorFlags = AccessorFlags.None,
            ITypeReference accessorType = null)
            : this()
        {
            this.isInInterface = isInInterface;
            this.accessorFlags = accessorFlags;
            this.accessorType = accessorType;
        }
        
        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        public override void VisitAccessor<TAttributeGroup>(IAccessor<TAttributeGroup> accessor)
        {
            bool isIndexer = accessorFlags.HasFlag(AccessorFlags.Indexer) && !isInInterface;
            Steps.Add(isIndexer ? (ISourceCodeBuilderStep)new WriteIndentedNewLine() : new WriteWhitespace());
            Steps.AddRange(accessor.Attributes.Select(attribute => new WriteChildNode<TAttributeGroup>(attribute)));
            Steps.Add(accessorFlags.HasFlag(AccessorFlags.Get) ? (ISourceCodeBuilderStep)new WriteGetKeyword() : new WriteSetKeyword());
            if (isIndexer)
            {
                Steps.Add(new WriteStartBrace());
                Steps.Add(new WriteWhitespace());
                if (accessorFlags.HasFlag(AccessorFlags.Get))
                {
                    string typeText = new WriteChildNode<ITypeReference>(accessorType).Steps.ToSourceCode();
                    Steps.Add(new WriteRawValue(string.Format("return default({0});", typeText)));
                }

                Steps.Add(new WriteWhitespace());
                Steps.Add(new WriteEndBrace());
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
            Steps.Add(new WriteChildNode<TClassReference>(attribute.AttributeType));
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
        
        public override void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> @class)
        {
            Steps.AddChildNodeStepsOnNewLines(@class.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@class.Visibility);
            Steps.AddTypeInheritanceModifierSteps(@class.InheritanceModifier);
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@class.Name));
            Steps.AddGenericParameterSteps(@class.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(@class, @class);
            Steps.AddGenericParameterConstraintSteps(@class.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddTypeBodySteps(@class, @class.Destructor == null ? null : new WriteChildNode<TDestructor>(@class.Destructor));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            Steps.Add(new WriteName(classReference.Name));
            Steps.AddGenericParameterSteps(classReference.GenericParameters);
        }

        public override void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
        {
            Steps.AddChildNodeStepsOnNewLines(constructor.Attributes);
            Steps.AddMemberVisibilityModifierSteps(constructor.Visibility);
            Steps.Add(new WriteName(((IHasName)constructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(constructor.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> conversionOperator)
        {
            Steps.AddChildNodeStepsOnNewLines(conversionOperator.Attributes);
            Steps.AddMemberVisibilityModifierSteps(MemberVisibilityModifier.Public);
            Steps.AddMemberInheritanceModifierSteps(MemberInheritanceModifier.Static);
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
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            Steps.AddChildNodeStepsOnNewLines(@delegate.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@delegate.Visibility);
            Steps.Add(new WriteDelegateKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(@delegate.ReturnType));
            Steps.AddGenericParameterSteps(@delegate.GenericParameters);
            Steps.Add(new WriteName(@delegate.Name));
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

        public override void VisitDestructor<TAttributeGroup, TDeclaringType>(IDestructor<TAttributeGroup, TDeclaringType> destructor)
        {
            Steps.AddChildNodeStepsOnNewLines(destructor.Attributes);
            Steps.Add(new WriteTilda());
            Steps.Add(new WriteName(((IHasName)destructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            Steps.AddChildNodeStepsOnNewLines(@enum.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@enum.Visibility);
            Steps.Add(new WriteEnumKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@enum.Name));
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.AddChildNodeSteps(@enum.EnumMembers, () => Steps.AddRange(new WriteComma(), new WriteIndentedNewLine()));
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

        public override void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Steps.AddMemberVisibilityModifierSteps(@event.Visibility);
            Steps.AddMemberInheritanceModifierSteps(@event.InheritanceModifier);
            Steps.Add(new WriteEventKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TDelegateReference>(@event.EventType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@event.Name));
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference> eventProperty)
        {
            Steps.AddMemberVisibilityModifierSteps(eventProperty.Visibility);
            Steps.AddMemberInheritanceModifierSteps(eventProperty.InheritanceModifier);
            Steps.Add(new WriteEventKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TDelegateReference>(eventProperty.EventType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(eventProperty.Name));
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteAddKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new WriteEndBrace());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteRemoveKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new WriteEndBrace());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            Steps.AddMemberVisibilityModifierSteps(field.Visibility);
            Steps.AddFieldModifierSteps(field.Modifier);
            Steps.Add(new WriteChildNode<TTypeReference>(field.FieldType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(field.Name));
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
                genericParameterDeclaration.InterfaceConstraints == null &&
                genericParameterDeclaration.TypeConstraint == GenericParameterTypeConstraint.None)
            {
                return;
            }

            Steps.Add(new WriteWhere());
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

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Steps.AddChildNodeStepsOnNewLines(indexer.Attributes);
            Steps.AddMemberVisibilityModifierSteps(indexer.Visibility);
            Steps.AddMemberInheritanceModifierSteps(indexer.InheritanceModifier);
            Steps.Add(new WriteChildNode<TTypeReference>(indexer.IndexerType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteThisKeyword());
            Steps.Add(new WriteStartBracket());
            Steps.AddCommaSeparatedChildNodeSteps(indexer.Parameters);
            Steps.Add(new WriteEndBracket());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Func<AccessorFlags, SourceCodeStepsBuilder> builderFactory =
                flags => new SourceCodeStepsBuilder(isInInterface, AccessorFlags.Property | flags, indexer.IndexerType);
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
            // TODO: Finish VisitIndexer
        }

        public override void VisitInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Steps.AddChildNodeStepsOnNewLines(@interface.Attributes);
            Steps.AddTypeVisibilityModifierSteps(@interface.Visibility);
            Steps.Add(new WriteInterfaceKeyword());
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
            Steps.Add(new WriteIndentedNewLine());
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

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            IEnumerable<ISourceCodeBuilderStep> steps =
                loadedDocument.Enums.Select(@enum => (ISourceCodeBuilderStep)new WriteChildNode<TEnum>(@enum))
                .Concat(loadedDocument.Delegates.Select(@delegate => new WriteChildNode<TDelegate>(@delegate)))
                .Concat(loadedDocument.Interfaces.Select(@interface => new WriteChildNode<TInterface>(@interface)))
                .Concat(loadedDocument.Structs.Select(@struct => new WriteChildNode<TStruct>(@struct)))
                .Concat(loadedDocument.Classes.Select(@class => new WriteChildNode<TClass>(@class)))
                .Concat(loadedDocument.Namespaces.Select(@namespace => new WriteChildNode<TNamespace>(@namespace)));
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
        }

        public override void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Steps.AddChildNodeStepsOnNewLines(method.Attributes);
            Steps.AddMemberVisibilityModifierSteps(method.Visibility);
            Steps.AddMemberInheritanceModifierSteps(method.InheritanceModifier);
            Steps.Add(new WriteChildNode<TTypeReference>(method.ReturnType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(method.Name));
            Steps.AddGenericParameterSteps(method.GenericParameters);
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(method.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(method.GenericParameters);
            if (isInInterface || method.InheritanceModifier == MemberInheritanceModifier.Abstract)
            {
                Steps.Add(new WriteSemicolon());
            }
            else
            {
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteStartBrace());
                Steps.Add(new IncrementIndent());
                Steps.Add(new WriteEmptyBody());
                Steps.Add(new DecrementIndent());
                Steps.Add(new WriteIndentedNewLine());
                Steps.Add(new WriteEndBrace());
            }
        }

        public override void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            Steps.Add(new WriteName(namedAttributeValue.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteEquals());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteRawValue(namedAttributeValue.RawValue));
        }

        public override void VisitNamespace<TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            Steps.Add(new WriteNamespaceKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(@namespace.Name));
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            IEnumerable<ISourceCodeBuilderStep> steps =
                @namespace.Enums.Select(@enum => (ISourceCodeBuilderStep)new WriteChildNode<TEnum>(@enum))
                .Concat(@namespace.Delegates.Select(@delegate => new WriteChildNode<TDelegate>(@delegate)))
                .Concat(@namespace.Interfaces.Select(@interface => new WriteChildNode<TInterface>(@interface)))
                .Concat(@namespace.Structs.Select(@struct => new WriteChildNode<TStruct>(@struct)))
                .Concat(@namespace.Classes.Select(@class => new WriteChildNode<TClass>(@class)));
            Steps.AddRange(steps, () => Steps.AddRange(new WriteNewLine(), new WriteIndentedNewLine()));
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor> nestedClass)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedClass.Attributes);
            Steps.AddMemberVisibilityModifierSteps(nestedClass.Visibility);
            Steps.AddTypeInheritanceModifierSteps(nestedClass.InheritanceModifier);
            Steps.Add(new WriteClassKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedClass.Name));
            Steps.AddGenericParameterSteps(nestedClass.GenericParameters);
            Steps.AddBaseClassAndImplementedInterfacesSteps(nestedClass, nestedClass);
            Steps.AddGenericParameterConstraintSteps(nestedClass.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddTypeBodySteps(nestedClass);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedDelegate.Attributes);
            Steps.AddMemberVisibilityModifierSteps(nestedDelegate.Visibility);
            Steps.Add(new WriteDelegateKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteChildNode<TTypeReference>(nestedDelegate.ReturnType));
            Steps.AddGenericParameterSteps(nestedDelegate.GenericParameters);
            Steps.Add(new WriteName(nestedDelegate.Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.AddCommaSeparatedChildNodeSteps(nestedDelegate.Parameters);
            Steps.Add(new WriteEndParenthesis());
            Steps.AddGenericParameterConstraintSteps(nestedDelegate.GenericParameters);
            Steps.Add(new WriteSemicolon());
        }

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType>(
            INestedDestructor<TAttributeGroup, TDeclaringType> nestedDestructor)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedDestructor.Attributes);
            Steps.Add(new WriteTilda());
            Steps.Add(new WriteName(((IHasName)nestedDestructor.DeclaringType).Name));
            Steps.Add(new WriteStartParenthesis());
            Steps.Add(new WriteEndParenthesis());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedEnum.Attributes);
            Steps.AddMemberVisibilityModifierSteps(nestedEnum.Visibility);
            Steps.Add(new WriteEnumKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedEnum.Name));
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

        public override void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            Steps.AddChildNodeStepsOnNewLines(@interface.Attributes);
            Steps.AddMemberVisibilityModifierSteps(@interface.Visibility);
            Steps.Add(new WriteInterfaceKeyword());
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
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddInterfaceBodySteps(@interface);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> nestedStruct)
        {
            Steps.AddChildNodeStepsOnNewLines(nestedStruct.Attributes);
            Steps.AddMemberVisibilityModifierSteps(nestedStruct.Visibility);
            Steps.Add(new WriteStructKeyword());
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(nestedStruct.Name));
            Steps.AddGenericParameterSteps(nestedStruct.GenericParameters);
            Steps.AddImplementedInterfacesSteps(nestedStruct);
            Steps.AddGenericParameterConstraintSteps(nestedStruct.GenericParameters);
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteStartBrace());
            Steps.Add(new IncrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddTypeBodySteps(nestedStruct);
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

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> operatorOverload)
        {
            Steps.AddChildNodeStepsOnNewLines(operatorOverload.Attributes);
            Steps.AddMemberVisibilityModifierSteps(MemberVisibilityModifier.Public);
            Steps.AddMemberInheritanceModifierSteps(MemberInheritanceModifier.Static);
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
            Steps.Add(new WriteEmptyBody());
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            Steps.AddChildNodeStepsOnNewLines(parameter.Attributes);
            Steps.AddMethodParameterModifierSteps(parameter.Modifier);
            Steps.Add(new WriteChildNode<TTypeReference>(parameter.ParameterType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(parameter.Name));
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Steps.AddChildNodeStepsOnNewLines(property.Attributes);
            Steps.AddMemberVisibilityModifierSteps(property.Visibility);
            Steps.AddMemberInheritanceModifierSteps(property.InheritanceModifier);
            Steps.Add(new WriteChildNode<TTypeReference>(property.PropertyType));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteName(property.Name));
            Steps.Add(new WriteWhitespace());
            Steps.Add(new WriteStartBrace());
            Func<AccessorFlags, SourceCodeStepsBuilder> builderFactory =
                flags => new SourceCodeStepsBuilder(isInInterface, AccessorFlags.Property | flags, property.PropertyType);
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

        public override void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> @struct)
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
            Steps.Add(new WriteIndentedNewLine());
            Steps.AddTypeBodySteps(@struct);
            Steps.Add(new DecrementIndent());
            Steps.Add(new WriteIndentedNewLine());
            Steps.Add(new WriteEndBrace());
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            Steps.Add(new WriteName(structReference.Name));
            Steps.AddGenericParameterSteps(structReference.GenericParameters);
        }

        public override void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            Steps.Add(new WriteRawValue(unnamedAttributeValue.RawValue));
        }

        public override void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecificTypeReference<TGenericParameter> unspecificTypeReference)
        {
            Steps.Add(new WriteName(unspecificTypeReference.Name));
            Steps.AddGenericParameterSteps(unspecificTypeReference.GenericParameters);
        }
    }
}
