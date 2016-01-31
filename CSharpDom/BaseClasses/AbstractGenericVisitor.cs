using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericVisitor : IGenericVisitor
    {
        public virtual void Visit(IVisitable<IGenericVisitor> node)
        {
            node.AcceptChildren(this);
        }

        public virtual void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            Visit(accessor);
        }

        public virtual void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
            where TTypeReference : ITypeReference
        {
            Visit(arrayTypeReference);
        }

        public Task VisitAsync(IAsyncVisitable<IGenericVisitor> node)
        {
            return VisitAsync(node);
        }

        public virtual void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
            where TClassReference : IClassReference
            where TUnnamedAttributeValue : IUnnamedAttributeValue
            where TNamedAttributeValue : INamedAttributeValue
        {
            Visit(attribute);
        }

        public virtual void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
            where TAttribute : IAttribute
        {
            Visit(attributes);
        }

        public virtual void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> @class)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
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
            where TDestructor : IDestructor
        {
            Visit(@class);
        }

        public virtual void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(classReference);
        }

        public virtual void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
        {
            Visit(constructor);
        }

        public virtual void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(conversionOperator);
        }

        public virtual void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(@delegate);
        }

        public virtual void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(delegateReference);
        }

        public virtual void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClass
            where TMethodBody : IMethodBody
        {
            Visit(destructor);
        }

        public virtual Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(
            IDocument<TProject, TSolution, TLoadedDocument> document)
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument
        {
            return VisitAsync(document);
        }

        public virtual void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TEnumMember : IEnumMember
        {
            Visit(@enum);
        }

        public virtual void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IEnum
        {
            Visit(enumMember);
        }

        public virtual void VisitEnumReference(IEnumReference enumReference)
        {
            Visit(enumReference);
        }

        public virtual void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IField<TAttributeGroup, TDeclaringType, TTypeReference> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
        {
            Visit(field);
        }

        public virtual void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
            where TTypeReference : ITypeReference
        {
            Visit(genericParameter);
        }

        public virtual void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
            where TClassReference : IClassReference
            where TGenericParameterReference : IGenericParameterReference
            where TInterfaceReference : IInterfaceReference
            where TAttributeGroup : IAttributeGroup
        {
            Visit(genericParameterDeclaration);
        }

        public virtual void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            Visit(genericParameterReference);
        }

        public virtual void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IEvent
            where TProperty : IProperty
            where TIndexer : IIndexer
            where TMethod : IMethod
        {
            Visit(@interface);
        }

        public virtual void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(interfaceReference);
        }

        public virtual void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective
            where TAttributeGroup : IAttributeGroup
            where TNamespace : INamespace
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct
        {
            Visit(loadedDocument);
        }

        public virtual void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(method);
        }

        public virtual void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody)
        {
            Visit(methodBody);
        }

        public virtual void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            Visit(namedAttributeValue);
        }

        public virtual void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct
        {
            Visit(@namespace);
        }

        public virtual void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
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
            where TNestedDestructor : INestedDestructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(nestedDelegate);
        }

        public virtual void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedClass
            where TMethodBody : IMethodBody
        {
            Visit(nestedDestructor);
        }

        public virtual void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedEnum
        {
            Visit(nestedEnumMember);
        }

        public virtual void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IEvent
            where TProperty : IProperty
            where TIndexer : IIndexer
            where TMethod : IMethod
        {
            Visit(@interface);
        }

        public virtual void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
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
            Visit(nestedStruct);
        }

        public virtual void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
            where TTypeReference : ITypeReference
        {
            Visit(nestedTypeReference);
        }

        public virtual void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(operatorOverload);
        }

        public virtual void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            Visit(parameter);
        }

        public virtual Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(IProject<TSolution, TDocument, TLoadedProject> project)
            where TSolution : ISolution
            where TDocument : IDocument
            where TLoadedProject : ILoadedProject
        {
            return VisitAsync(project);
        }

        public virtual void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor
        {
            Visit(property);
        }

        public virtual Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
            where TProject : IProject
        {
            return VisitAsync(solution);
        }

        public virtual void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> @struct)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
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
            Visit(@struct);
        }

        public virtual void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(structReference);
        }

        public virtual void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            Visit(unnamedAttributeValue);
        }

        public virtual void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecificTypeReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(unspecificTypeReference);
        }

        public virtual void VisitUsingDirective(IUsingDirective usingDirective)
        {
            Visit(usingDirective);
        }
    }
}
