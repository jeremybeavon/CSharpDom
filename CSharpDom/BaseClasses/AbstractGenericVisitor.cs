using System;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericVisitor : IGenericVisitor
    {
        public virtual void VisitAccessor<TAttributeGroup>(IAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup
        {
            accessor.AcceptChildren(this);
        }

        public virtual void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
            where TTypeReference : ITypeReference
        {
            arrayTypeReference.AcceptChildren(this);
        }

        public virtual void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
            where TClassReference : IClassReference
            where TUnnamedAttributeValue : IUnnamedAttributeValue
            where TNamedAttributeValue : INamedAttributeValue
        {
            attribute.AcceptChildren(this);
        }

        public virtual void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
            where TAttribute : IAttribute
        {
            attributes.AcceptChildren(this);
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
            @class.AcceptChildren(this);
        }

        public virtual void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
            where TGenericParameter : IGenericParameter
        {
            classReference.AcceptChildren(this);
        }

        public virtual void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
        {
            constructor.AcceptChildren(this);
        }

        public virtual void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> conversionOperator)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            conversionOperator.AcceptChildren(this);
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
            @delegate.AcceptChildren(this);
        }

        public virtual void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
            where TGenericParameter : IGenericParameter
        {
            delegateReference.AcceptChildren(this);
        }

        public virtual void VisitDestructor<TAttributeGroup, TDeclaringType>(IDestructor<TAttributeGroup, TDeclaringType> destructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClass
        {
            destructor.AcceptChildren(this);
        }

        public virtual Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(
            IDocument<TProject, TSolution, TLoadedDocument> document)
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument
        {
            return document.AcceptChildrenAsync(this);
        }

        public virtual void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TEnumMember : IEnumMember
        {
            @enum.AcceptChildren(this);
        }

        public virtual void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IEnum
        {
            enumMember.AcceptChildren(this);
        }

        public virtual void VisitEnumReference(IEnumReference enumReference)
        {
            enumReference.AcceptChildren(this);
        }

        public virtual void VisitEvent<TAttributeGroup, TDeclaringType, TTypeReference>(
            IEvent<TAttributeGroup, TDeclaringType, TTypeReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
        {
            @event.AcceptChildren(this);
        }

        public virtual void VisitEventProperty<TAttributeGroup, TDeclaringType, TTypeReference>(
            IEventProperty<TAttributeGroup, TDeclaringType, TTypeReference> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
        {
            eventProperty.AcceptChildren(this);
        }

        public virtual void VisitField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IField<TAttributeGroup, TDeclaringType, TTypeReference> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
        {
            field.AcceptChildren(this);
        }

        public virtual void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
            where TTypeReference : ITypeReference
        {
            genericParameter.AcceptChildren(this);
        }

        public virtual void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
            where TClassReference : IClassReference
            where TGenericParameterReference : IGenericParameterReference
            where TInterfaceReference : IInterfaceReference
            where TAttributeGroup : IAttributeGroup
        {
            genericParameterDeclaration.AcceptChildren(this);
        }

        public virtual void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            genericParameterReference.AcceptChildren(this);
        }

        public virtual void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IAccessor
        {
            indexer.AcceptChildren(this);
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
            @interface.AcceptChildren(this);
        }

        public virtual void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
            where TGenericParameter : IGenericParameter
        {
            interfaceReference.AcceptChildren(this);
        }

        public virtual void VisitLoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TNamespace : INamespace
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct
        {
            loadedDocument.AcceptChildren(this);
        }

        public virtual void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            method.AcceptChildren(this);
        }

        public virtual void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            namedAttributeValue.AcceptChildren(this);
        }

        public virtual void VisitNamespace<TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct
        {
            @namespace.AcceptChildren(this);
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
            nestedClass.AcceptChildren(this);
        }

        public virtual void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            nestedDelegate.AcceptChildren(this);
        }

        public virtual void VisitNestedDestructor<TAttributeGroup, TDeclaringType>(
            INestedDestructor<TAttributeGroup, TDeclaringType> nestedDestructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedClass
        {
            nestedDestructor.AcceptChildren(this);
        }

        public virtual void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            nestedEnum.AcceptChildren(this);
        }

        public virtual void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedEnum
        {
            nestedEnumMember.AcceptChildren(this);
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
            @interface.AcceptChildren(this);
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
            nestedStruct.AcceptChildren(this);
        }

        public virtual void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
            where TTypeReference : ITypeReference
        {
            nestedTypeReference.AcceptChildren(this);
        }

        public virtual void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> operatorOverload)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            operatorOverload.AcceptChildren(this);
        }

        public virtual void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            parameter.AcceptChildren(this);
        }

        public virtual Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(IProject<TSolution, TDocument, TLoadedProject> project)
            where TSolution : ISolution
            where TDocument : IDocument
            where TLoadedProject : ILoadedProject
        {
            return project.AcceptChildrenAsync(this);
        }

        public virtual void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor
        {
            property.AcceptChildren(this);
        }

        public virtual Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
            where TProject : IProject
        {
            return solution.AcceptChildrenAsync(this);
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
            @struct.AcceptChildren(this);
        }

        public virtual void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
            where TGenericParameter : IGenericParameter
        {
            structReference.AcceptChildren(this);
        }

        public virtual void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            unnamedAttributeValue.AcceptChildren(this);
        }

        public virtual void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecificTypeReference<TGenericParameter> unspecificTypeReference)
            where TGenericParameter : IGenericParameter
        {
            unspecificTypeReference.AcceptChildren(this);
        }
    }
}
