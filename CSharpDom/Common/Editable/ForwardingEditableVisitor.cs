using System;
using System.Threading.Tasks;
using CSharpDom.BaseClasses;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable
{
    public sealed class ForwardingEditableVisitor : IGenericVisitor
    {
        private readonly IEditableVisitor visitor;

        public ForwardingEditableVisitor(IEditableVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void Visit(IVisitable<IGenericVisitor> node)
        {
            throw new NotSupportedException();
        }

        public void VisitAbstractAccessor<TAttributeGroup>(IAbstractAccessor<TAttributeGroup> accessor) where TAttributeGroup : IAttributeGroup
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TAbstractEvent : IAbstractEvent
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IClassIndexer
            where TAbstractIndexer : IAbstractIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IClassMethod
            where TAbstractMethod : IAbstractMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IClassProperty
            where TAbstractProperty : IAbstractProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAbstractAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IClassMethod
            where TAbstractMethod : IAbstractMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TAccessor : IAbstractAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public Task VisitAsync(IAsyncVisitable<IGenericVisitor> node)
        {
            throw new NotSupportedException();
        }

        public void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
            where TClassReference : IClassReference
            where TUnnamedAttributeValue : IUnnamedAttributeValue
            where TNamedAttributeValue : INamedAttributeValue
        {
            throw new System.NotImplementedException();
        }

        public void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes) where TAttribute : IAttribute
        {
            throw new System.NotImplementedException();
        }

        public void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            throw new System.NotImplementedException();
        }

        public void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassAccessor<TAttributeGroup, TMethodBody>(IClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IClass
            where TAbstractClass : IAbstractClass
            where TSealedClass : ISealedClass
            where TStaticClass : IStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassFieldCollection<TField, TConstant>(IClassFieldCollection<TField, TConstant> fieldCollection)
            where TField : IClassField
            where TConstant : IClassConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IClassAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> nestedClass)
            where TClass : IClassNestedClass
            where TAbstractClass : IClassNestedAbstractClass
            where TSealedClass : IClassNestedSealedClass
            where TStaticClass : IClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TNestedEnumMember : INestedEnumMember
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IPartialStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
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
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassNestedStructCollection<TStruct, TPartialStruct>(IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IClassNestedStruct
            where TPartialStruct : IClassNestedPartialStruct
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IClassProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassReference<TTypeReference>(IClassReference<TTypeReference> classReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitConstant<TExpression>(IConstant<TExpression> constant) where TExpression : IExpression
        {
            throw new System.NotImplementedException();
        }

        public void VisitConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constantGroup)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitConstructorParameter<TAttributeGroup, TTypeReference>(IConstructorParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IOperatorParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitDelegateParameter<TAttributeGroup, TTypeReference>(IDelegateParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitDelegateReference<TTypeReference>(IDelegateReference<TTypeReference> delegateReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(IDocument<TProject, TSolution, TLoadedDocument> document)
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument
        {
            throw new System.NotImplementedException();
        }

        public void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TEnumMember : IEnumMember
        {
            throw new System.NotImplementedException();
        }

        public void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IEnum
        {
            throw new System.NotImplementedException();
        }

        public void VisitEnumReference(IEnumReference enumReference)
        {
            throw new System.NotImplementedException();
        }

        public void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticClass
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TExtensionParameter : IExtensionParameter
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitExtensionParameter<TAttributeGroup, TTypeReference>(IExtensionParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitField<TExpression>(IField<TExpression> field) where TExpression : IExpression
        {
            throw new System.NotImplementedException();
        }

        public void VisitFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>(IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> fieldGroup)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            throw new System.NotImplementedException();
        }

        public void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
            where TClassReference : IClassReference
            where TGenericParameterReference : IGenericParameterReference
            where TInterfaceReference : IInterfaceReference
            where TAttributeGroup : IAttributeGroup
        {
            throw new System.NotImplementedException();
        }

        public void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            throw new System.NotImplementedException();
        }

        public void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitIndexerParameter<TAttributeGroup, TTypeReference>(IIndexerParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
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
            throw new System.NotImplementedException();
        }

        public void VisitInterfaceAccessor<TAttributeGroup>(IInterfaceAccessor<TAttributeGroup> accessor) where TAttributeGroup : IAttributeGroup
        {
            throw new System.NotImplementedException();
        }

        public void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IInterfaceAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TTypeReference : ITypeReference
            where TAccessor : IInterfaceAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitInterfaceReference<TTypeReference>(IInterfaceReference<TTypeReference> interfaceReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> loadedDocument)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective
            where TAttributeGroup : IAttributeGroup
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStructCollection : IStructCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody)
        {
            throw new System.NotImplementedException();
        }

        public void VisitMethodParameter<TAttributeGroup, TTypeReference>(IMethodParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitNamedAttributeValue<TExpression>(INamedAttributeValue<TExpression> namedAttributeValue) where TExpression : IExpression
        {
            throw new System.NotImplementedException();
        }

        public void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> @namespace)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStructCollection : IStructCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : INestedClass
            where TAbstractClass : INestedAbstractClass
            where TSealedClass : INestedSealedClass
            where TStaticClass : INestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedEnum
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedStaticClassMethodCollection<TMethod>(INestedStaticClassMethodCollection<TMethod> methodCollection) where TMethod : IStaticClassMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>(INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IStaticClassMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
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
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedStructCollection<TStruct, TPartialStruct>(INestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : INestedStruct
            where TPartialStruct : INestedPartialStruct
        {
            throw new System.NotImplementedException();
        }

        public void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitNullableTypeReference<TStructReference>(INullableTypeReference<TStructReference> reference) where TStructReference : IStructReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IOperatorParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitOperatorParameter<TAttributeGroup, TTypeReference>(IOperatorParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>(IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> classes)
            where TClass : IClassType
            where TAbstractClass : IAbstractType
            where TSealedClass : ISealedType
            where TStaticClass : IStaticType
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>(IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TParameter : IMethodParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
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
            where TMethodCollection : IPartialStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IStructMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation
        {
            throw new System.NotImplementedException();
        }

        public Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(IProject<TSolution, TDocument, TLoadedProject> project)
            where TSolution : ISolution
            where TDocument : IDocument
            where TLoadedProject : ILoadedProject
        {
            throw new System.NotImplementedException();
        }

        public void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : ISealedClassEvent
            where TEventProperty : ISealedClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IClassAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : ISealedClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : ISealedClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : ISealedClassProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(ISealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
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
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(ISealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : ISealedClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation
        {
            throw new System.NotImplementedException();
        }

        public void VisitSealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(ISealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public Task VisitSolutionAsync<TProject>(ISolution<TProject> solution) where TProject : IProject
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
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
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassEventCollection<TEvent, TEventProperty>(IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
            where TEvent : IStaticClassEvent
            where TEventProperty : IStaticClassEventProperty
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassFieldCollection<TFieldGroup, TConstantGroup>(IStaticClassFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IStaticClassField
            where TConstantGroup : IStaticClassConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
            where TMethod : IStaticClassMethod
            where TExtensionMethod : IExtensionMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IStaticClassNestedClass
            where TAbstractClass : IStaticClassNestedAbstractClass
            where TSealedClass : IStaticClassNestedSealedClass
            where TStaticClass : IStaticClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TNestedEnumMember : INestedEnumMember
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IPartialStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
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
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStaticClassNestedStruct
            where TPartialStruct : IStaticClassNestedPartialStruct
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TAccessor : IStaticClassAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>(IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IStaticClassMethod
            where TExtensionMethod : IExtensionMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation
        {
            throw new System.NotImplementedException();
        }

        public void VisitStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
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
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructAccessor<TAttributeGroup, TMethodBody>(IStructAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructCollection<TStruct, TPartialStruct>(IStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStruct
            where TPartialStruct : IPartialStruct
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TDelegateReference : IDelegateReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IStructEvent
            where TEventProperty : IStructEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructFieldCollection<TFieldGroup, TConstantGroup>(IStructFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IStructField
            where TConstantGroup : IStructConstant
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IStructAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IStructIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IStructMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
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
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IStructNestedClass
            where TAbstractClass : IStructNestedAbstractClass
            where TSealedClass : IStructNestedSealedClass
            where TStaticClass : IStructNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TNestedEnumMember : INestedEnumMember
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IPartialStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(IStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
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
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructNestedStructCollection<TStruct, TPartialStruct>(IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStructNestedStruct
            where TPartialStruct : IStructNestedPartialStruct
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TAccessor : IStructAccessor
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructPropertyCollection<TProperty, TExplicitInterfaceProperty>(IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IStructProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructReference<TTypeReference>(IStructReference<TTypeReference> structReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
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
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
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
            where TNestedInterface : INestedInterface
            where TNestedStructCollection : INestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            throw new System.NotImplementedException();
        }

        public void VisitTypeReference(ITypeReference typeReference)
        {
            throw new System.NotImplementedException();
        }

        public void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue) where TExpression : IExpression
        {
            throw new System.NotImplementedException();
        }

        public void VisitUnspecifiedTypeReference<TTypeReference>(IUnspecifiedTypeReference<TTypeReference> unspecificTypeReference) where TTypeReference : ITypeReference
        {
            throw new System.NotImplementedException();
        }

        public void VisitUsingDirective(IUsingDirective usingDirective)
        {
            throw new System.NotImplementedException();
        }
    }
}
