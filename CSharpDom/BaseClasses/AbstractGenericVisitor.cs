using System;
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

        public virtual void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
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

        public virtual void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IClassAccessor
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

        public virtual void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
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

        

        public virtual void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
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
            where TDeclaringType : IClassNestedClass
            where TMethodBody : IMethodBody
        {
            Visit(nestedDestructor);
        }

        public virtual void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassNestedEnum
        {
            Visit(nestedEnumMember);
        }

        public virtual void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
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
            where TDeclaringType : IType
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
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
        {
            Visit(@event);
        }

        public virtual void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            Visit(eventProperty);
        }

        public virtual void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
        {
            Visit(field);
        }

        public virtual void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IStructAccessor
        {
            Visit(indexer);
        }

        public virtual void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
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
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
        {
            Visit(nestedDelegate);
        }

        public virtual void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            Visit(nestedEnum);
        }

        public virtual void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
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
        
        public virtual void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
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

        public virtual void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @class)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEvent : IClassEvent
            where TProperty : IClassProperty
            where TIndexer : IClassIndexer
            where TMethod : IClassMethod
            where TField : IClassField
            where TConstructor : IClassConstructor
            where TEventProperty : IClassEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IClassNestedClass
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStruct : IClassNestedStruct
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(@class);
        }

        public virtual void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(constructor);
        }

        public virtual void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEvent : IClassEvent
            where TProperty : IClassProperty
            where TIndexer : IClassIndexer
            where TMethod : IClassMethod
            where TField : IClassField
            where TConstructor : IClassConstructor
            where TEventProperty : IClassEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IClassNestedClass
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStruct : IClassNestedStruct
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(nestedClass);
        }

        public virtual void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IStructEvent
            where TProperty : IStructProperty
            where TIndexer : IStructIndexer
            where TMethod : IStructMethod
            where TField : IStructField
            where TConstructor : IStructConstructor
            where TEventProperty : IStructEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IStructNestedClass
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStruct : IStructNestedStruct
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(nestedStruct);
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

        public virtual void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
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

        public virtual void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
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

        public virtual void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @struct)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IStructEvent
            where TProperty : IStructProperty
            where TIndexer : IStructIndexer
            where TMethod : IStructMethod
            where TField : IStructField
            where TConstructor : IStructConstructor
            where TEventProperty : IStructEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IStructNestedClass
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStruct : IStructNestedStruct
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(@struct);
        }

        public virtual void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            Visit(constructor);
        }

        public virtual void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEvent : IClassEvent
            where TProperty : IClassProperty
            where TIndexer : IClassIndexer
            where TMethod : IClassMethod
            where TField : IClassField
            where TConstructor : IClassConstructor
            where TEventProperty : IClassEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IClassNestedClass
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStruct : IClassNestedStruct
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(nestedClass);
        }

        public virtual void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IStructEvent
            where TProperty : IStructProperty
            where TIndexer : IStructIndexer
            where TMethod : IStructMethod
            where TField : IStructField
            where TConstructor : IStructConstructor
            where TEventProperty : IStructEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IStructNestedClass
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStruct : IStructNestedStruct
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            Visit(nestedStruct);
        }

        public virtual void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            Visit(accessor);
        }
    }
}
