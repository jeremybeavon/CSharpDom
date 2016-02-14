using System;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractGenericVisitor : IGenericVisitor
    {
        public virtual void Visit(IVisitable<IGenericVisitor> node)
        {
            node.AcceptChildren(this);
        }

        public virtual void VisitClassAccessor<TAttributeGroup, TMethodBody>(IClassAccessor<TAttributeGroup, TMethodBody> accessor)
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

        public virtual Task VisitAsync(IAsyncVisitable<IGenericVisitor> node)
        {
            return node.AcceptChildrenAsync(this);
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
        
        public virtual void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(classReference);
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

        public virtual void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TNamespace : INamespace
            where TDocument : IDocument
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

        public virtual void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : INamespace
            where TDocument : IDocument
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

        public virtual void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TField : IField
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

        public virtual void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IClassAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Visit(@interface);
        }

        public virtual void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(interfaceReference);
        }

        public virtual void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> loadedDocument)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective
            where TAttributeGroup : IAttributeGroup
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterfaceCollection : IInterfaceCollection
            where TStructCollection : IStructCollection
        {
            Visit(loadedDocument);
        }

        public virtual void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
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
        
        public virtual void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> @namespace)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterfaceCollection : IInterfaceCollection
            where TStructCollection : IStructCollection
        {
            Visit(@namespace);
        }
        
        public virtual void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
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

        public virtual void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
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

        public virtual void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Visit(@interface);
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

        public virtual void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAccessor
        {
            Visit(property);
        }

        public virtual Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
            where TProject : IProject
        {
            return VisitAsync(solution);
        }
        
        public virtual void VisitStructAccessor<TAttributeGroup, TMethodBody>(
            IStructAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            Visit(accessor);
        }
        
        public virtual void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            Visit(field);
        }

        public virtual void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IStructAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(method);
        }
        
        public virtual void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(nestedDelegate);
        }

        public virtual void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Visit(@interface);
        }
        
        public virtual void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TAccessor : IStructAccessor
        {
            Visit(property);
        }

        public virtual void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
            where TGenericParameter : IGenericParameter
        {
            Visit(structReference);
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

        public virtual void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(constructor);
        }

        
        public virtual void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(@event);
        }

        public virtual void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(method);
        }

        public virtual void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor
        {
            Visit(property);
        }

        public virtual void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IInterfaceAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(method);
        }

        public virtual void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IInterfaceAccessor
        {
            Visit(property);
        }

        public virtual void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TMethodBody : IMethodBody
        {
            Visit(staticConstructor);
        }
        
        public virtual void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(constructor);
        }
        
        public virtual void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            Visit(accessor);
        }

        public virtual void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(constructor);
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

        public virtual void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(method);
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

        public virtual void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Visit(@interface);
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
        
        public virtual void VisitInterfaceAccessor<TAttributeGroup>(IInterfaceAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup
        {
            Visit(accessor);
        }

        public virtual void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            Visit(builtInTypeReference);
        }

        public virtual void VisitNullableTypeReference<TStructReference>(INullableTypeReference<TStructReference> reference)
            where TStructReference : IStructReference
        {
            Visit(reference);
        }

        public virtual void VisitAbstractAccessor<TAttributeGroup>(
            IAbstractAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup
        {
            Visit(accessor);
        }
        
        public virtual void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IAbstractAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(method);
        }

        public virtual void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TAccessor : IAbstractAccessor
        {
            Visit(property);
        }
        
        public virtual void VisitSealedClassAccessor<TAttributeGroup, TMethodBody>(
            ISealedClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            Visit(accessor);
        }

        public virtual void VisitSealedClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            ISealedClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(constructor);
        }

        public virtual void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitSealedClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            ISealedClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            Visit(field);
        }

        public virtual void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : ISealedClassAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(method);
        }
        
        public virtual void VisitSealedClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            ISealedClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(nestedDelegate);
        }

        public virtual void VisitSealedClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            ISealedClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitSealedClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            ISealedClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Visit(@interface);
        }
        
        public virtual void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TAccessor : ISealedClassAccessor
        {
            Visit(property);
        }
        
        public virtual void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(
            IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            Visit(accessor);
        }

        public virtual void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            Visit(field);
        }

        public virtual void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(method);
        }
        
        public virtual void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(nestedDelegate);
        }

        public virtual void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            Visit(@interface);
        }
        
        public virtual void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TAccessor : IStaticClassAccessor
        {
            Visit(property);
        }

        public virtual void VisitNamedAttributeValue<TExpression>(INamedAttributeValue<TExpression> namedAttributeValue)
            where TExpression : IExpression
        {
            Visit(namedAttributeValue);
        }

        public virtual void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue)
            where TExpression : IExpression
        {
            Visit(unnamedAttributeValue);
        }

        public virtual void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(@class);
        }

        public virtual void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TAbstractEvent : IAbstractEvent
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            Visit(eventCollection);
        }

        public virtual void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IClassIndexer
            where TAbstractIndexer : IAbstractIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            Visit(indexerCollection);
        }

        public virtual void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IClassMethod
            where TAbstractMethod : IAbstractMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(methodCollection);
        }

        public virtual void VisitAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IClassProperty
            where TAbstractProperty : IAbstractProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            Visit(propertyCollection);
        }

        public virtual void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(@class);
        }

        public virtual void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStruct);
        }

        public virtual void VisitSealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(@class);
        }

        public virtual void VisitSealedClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            ISealedClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedSealedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedSealedClass);
        }

        public virtual void VisitSealedClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            ISealedClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStruct);
        }

        public virtual void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(@class);
        }

        public virtual void VisitStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedStaticClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStaticClass);
        }

        public virtual void VisitStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStruct);
        }

        public virtual void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @struct)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(@struct);
        }

        public virtual void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStruct);
        }

        public virtual void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStruct);
        }

        public virtual void VisitType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type)
            where TEventCollection : IEventCollection
            where TPropertyCollection : IPropertyCollection
            where TIndexerCollection : IIndexerCollection
            where TMethodCollection : IMethodCollection
            where TFieldCollection : IFieldCollection
            where TConstructor : IConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : INestedClassCollection
            where TNestedDelegate : INestedDelegate
            where TNestedEnum : INestedEnum
            where TNestedInterfaceCollection : INestedInterfaceCollection
            where TNestedStructCollection : INestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(type);
        }

        public virtual void VisitAbstractType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IAbstractType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type)
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(type);
        }

        public virtual void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IClass
            where TAbstractClass : IAbstractClass
            where TSealedClass : ISealedClass
            where TStaticClass : IStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            Visit(classCollection);
        }

        public virtual void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            Visit(classConstant);
        }

        public virtual void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            Visit(eventCollection);
        }

        public virtual void VisitClassFieldCollection<TField, TConstant>(IClassFieldCollection<TField, TConstant> fieldCollection)
            where TField : IClassField
            where TConstant : IClassConstant
        {
            Visit(fieldCollection);
        }

        public virtual void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            Visit(indexerCollection);
        }

        public virtual void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(methodCollection);
        }

        public virtual void VisitClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IClassNestedClass
            where TAbstractClass : IClassNestedAbstractClass
            where TSealedClass : IClassNestedSealedClass
            where TStaticClass : IClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            Visit(classCollection);
        }

        public virtual void VisitClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
            where TInterface : IClassNestedInterface
            where TPartialInterface : IPartialInterface
        {
            Visit(interfaceCollection);
        }

        public virtual void VisitClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IClassNestedStruct
            where TPartialStruct : IPartialStruct
        {
            Visit(structCollection);
        }

        public virtual void VisitClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IClassProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            Visit(propertyCollection);
        }

        public virtual void VisitClassType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            Visit(@class);
        }

        public virtual void VisitConstant<TExpression>(IConstant<TExpression> constant)
            where TExpression : IExpression
        {
            Visit(constant);
        }

        public virtual void VisitConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constantGroup)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            Visit(constantGroup);
        }

        public virtual void VisitField<TExpression>(IField<TExpression> field)
            where TExpression : IExpression
        {
            Visit(field);
        }

        public virtual void VisitFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> fieldGroup)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            Visit(fieldGroup);
        }

        public virtual void VisitNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : INestedClass
            where TAbstractClass : INestedAbstractClass
            where TSealedClass : INestedSealedClass
            where TStaticClass : INestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            Visit(classCollection);
        }

        public virtual void VisitNestedInterfaceCollection<TInterface, TPartialInterface>(
            INestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
            where TInterface : INestedInterface
            where TPartialInterface : IPartialInterface
        {
            Visit(interfaceCollection);
        }

        public virtual void VisitNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @class)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(@class);
        }

        public virtual void VisitNestedStructCollection<TStruct, TPartialStruct>(
            INestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : INestedStruct
            where TPartialStruct : IPartialStruct
        {
            Visit(structCollection);
        }
        
        public virtual void VisitSealedClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            ISealedClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            Visit(constant);
        }

        public virtual void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : ISealedClassEvent
            where TEventProperty : IClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            Visit(eventCollection);
        }

        public virtual void VisitSealedClassFieldCollection<TFieldGroup, TConstantGroup>(
            ISealedClassFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : ISealedClassField
            where TConstantGroup : ISealedClassConstant
        {
            Visit(fieldCollection);
        }

        public virtual void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : ISealedClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            Visit(indexerCollection);
        }

        public virtual void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : ISealedClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(methodCollection);
        }

        public virtual void VisitSealedClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            ISealedClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitSealedClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            ISealedClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : ISealedClassNestedClass
            where TAbstractClass : ISealedClassNestedAbstractClass
            where TSealedClass : ISealedClassNestedSealedClass
            where TStaticClass : ISealedClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            Visit(classCollection);
        }

        public virtual void VisitSealedClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            ISealedClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
            where TInterface : ISealedClassNestedInterface
            where TPartialInterface : IPartialInterface
        {
            Visit(interfaceCollection);
        }

        public virtual void VisitSealedClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            ISealedClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitSealedClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            ISealedClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitSealedClassNestedStructCollection<TStruct, TPartialStruct>(
            ISealedClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : ISealedClassNestedStruct
            where TPartialStruct : IPartialStruct
        {
            Visit(structCollection);
        }

        public virtual void VisitSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : ISealedClassProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            Visit(propertyCollection);
        }

        public virtual void VisitSealedType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            ISealedType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type)
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(type);
        }

        public virtual void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            Visit(constant);
        }

        public virtual void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
            where TEvent : IStaticClassEvent
            where TEventProperty : IStaticClassEventProperty
        {
            Visit(eventCollection);
        }

        public virtual void VisitStaticClassFieldCollection<TFieldGroup, TConstantGroup>(
            IStaticClassFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IStaticClassField
            where TConstantGroup : IStaticClassConstant
        {
            Visit(fieldCollection);
        }

        public virtual void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
            where TMethod : IClassMethod
            where TExtensionMethod : IExtensionMethod
        {
            Visit(methodCollection);
        }

        public virtual void VisitStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IStaticClassNestedClass
            where TAbstractClass : IStaticClassNestedAbstractClass
            where TSealedClass : IStaticClassNestedSealedClass
            where TStaticClass : IStaticClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            Visit(classCollection);
        }

        public virtual void VisitStaticClassNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
            where TInterface : IStaticClassNestedInterface
            where TPartialInterface : IPartialInterface
        {
            Visit(interfaceCollection);
        }

        public virtual void VisitStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStaticClassNestedStruct
            where TPartialStruct : IPartialStruct
        {
            Visit(structCollection);
        }

        public virtual void VisitStructCollection<TStruct, TPartialStruct>(
            IStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStruct
            where TPartialStruct : IPartialStruct
        {
            Visit(structCollection);
        }

        public virtual void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IStructEvent
            where TEventProperty : IStructEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            Visit(eventCollection);
        }

        public virtual void VisitStructFieldCollection<TFieldGroup, TConstantGroup>(
            IStructFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IStructField
            where TConstantGroup : IStructConstant
        {
            Visit(fieldCollection);
        }

        public virtual void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IStructIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            Visit(indexerCollection);
        }

        public virtual void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IStructMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(methodCollection);
        }

        public virtual void VisitStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IStructNestedClass
            where TAbstractClass : IStructNestedAbstractClass
            where TSealedClass : IStructNestedSealedClass
            where TStaticClass : IStructNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            Visit(classCollection);
        }

        public virtual void VisitStructNestedInterfaceCollection<TInterface, TPartialInterface>(
            IStructNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
            where TInterface : IStructNestedInterface
            where TPartialInterface : IPartialInterface
        {
            Visit(interfaceCollection);
        }

        public virtual void VisitStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : ISealedClassFieldCollection
            where TConstructor : ISealedClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : ISealedClassNestedClassCollection
            where TNestedDelegate : ISealedClassNestedDelegate
            where TNestedEnum : ISealedClassNestedEnum
            where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
            where TNestedStructCollection : ISealedClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedStruct);
        }

        public virtual void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(nestedClass);
        }

        public virtual void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStructNestedStruct
            where TPartialStruct : IPartialStruct
        {
            Visit(structCollection);
        }

        public virtual void VisitStructPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IStructProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            Visit(propertyCollection);
        }

        public virtual void VisitStructType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type)
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            Visit(type);
        }

        public virtual void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            Visit(constant);
        }

        public virtual void VisitInterfaceCollection<TInterface, TPartialInterface>(
            IInterfaceCollection<TInterface, TPartialInterface> interfaceCollection)
            where TInterface : IInterface
            where TPartialInterface : IPartialInterface
        {
            Visit(interfaceCollection);
        }
    }
}
