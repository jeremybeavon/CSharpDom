using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IGenericVisitor
    {
        void Visit(IVisitable<IGenericVisitor> node);

        void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;

        Task VisitAsync(IAsyncVisitable<IGenericVisitor> node);

        void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
            where TTypeReference : ITypeReference;

        void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
            where TAttribute : IAttribute;

        void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
            where TClassReference : IClassReference
            where TUnnamedAttributeValue : IUnnamedAttributeValue
            where TNamedAttributeValue : INamedAttributeValue;

        void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
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
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitClassAccessor<TAttributeGroup, TMethodBody>(IClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;

        void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference;

        void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference;

        void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IClassAccessor;

        void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
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
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter;

        void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember;

        void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
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
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAccessor;

        void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
            where TGenericParameter : IGenericParameter;

        void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter;

        void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
            where TGenericParameter : IGenericParameter;

        void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClass
            where TMethodBody : IMethodBody;

        Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(IDocument<TProject, TSolution, TLoadedDocument> document)
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument;

        void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : INamespace
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TEnumMember : IEnumMember;

        void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IEnum;

        void VisitEnumReference(IEnumReference enumReference);

        void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IAccessor;

        void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor;


        void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
            where TTypeReference : ITypeReference;

        void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
            where TClassReference : IClassReference
            where TGenericParameterReference : IGenericParameterReference
            where TInterfaceReference : IInterfaceReference
            where TAttributeGroup : IAttributeGroup;

        void VisitGenericParameterReference(IGenericParameterReference genericParameterReference);

        void VisitInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
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
            where TMethod : IInterfaceMethod;

        void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TDelegateReference : IDelegateReference;

        void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IParameter;

        void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter;

        void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference;

        void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
            where TGenericParameter : IGenericParameter;

        void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
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
            where TStruct : IStruct;

        void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody);

        void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue);

        void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct;

        void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassNestedClass
            where TMethodBody : IMethodBody;

        void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassNestedEnum;

        void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
            where TTypeReference : ITypeReference;

        void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(IProject<TSolution, TDocument, TLoadedProject> project)
            where TSolution : ISolution
            where TDocument : IDocument
            where TLoadedProject : ILoadedProject;
        
        Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
            where TProject : IProject;

        void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TMethodBody : IMethodBody;

        void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
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
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitStructAccessor<TAttributeGroup, TMethodBody>(IStructAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;

        void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference;

        void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference;

        void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TAccessor : IStructAccessor;

        void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
            where TMethodBody : IMethodBody;

        void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
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
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;


        void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter;

        void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember;

        void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
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
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TAccessor : IStructAccessor;

        void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
            where TGenericParameter : IGenericParameter;

        void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue);

        void VisitUnspecifiedTypeReference<TGenericParameter>(IUnspecifiedTypeReference<TGenericParameter> unspecificTypeReference)
            where TGenericParameter : IGenericParameter;

        void VisitUsingDirective(IUsingDirective usingDirective);
    }
}
