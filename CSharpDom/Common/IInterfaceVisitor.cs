using CSharpDom.Common.Expressions;
using CSharpDom.Common.Partial;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IInterfaceVisitor
    {
        void VisitAbstractAccessor(IAbstractAccessor accessor);

        void VisitAbstractClass(IAbstractClass @class);

        void VisitAbstractPartialClass(IAbstractPartialClass @class);

        void VisitAbstractClassEventCollection(IAbstractClassEventCollection eventCollection);

        void VisitAbstractClassIndexerCollection(IAbstractClassIndexerCollection indexerCollection);

        void VisitAbstractClassMethodCollection(IAbstractClassMethodCollection methodCollection);

        void VisitAbstractPartialClassMethodCollection(IAbstractPartialClassMethodCollection methodCollection);

        void VisitAbstractClassPropertyCollection(IAbstractClassPropertyCollection propertyCollection);

        void VisitAbstractEvent(IAbstractEvent @event);

        void VisitAbstractIndexer(IAbstractIndexer indexer);

        void VisitAbstractMethod(IAbstractMethod method);

        void VisitAbstractProperty(IAbstractProperty property);

        void VisitAccessor(IAccessor accessor);
        
        void VisitArrayTypeReference(IArrayTypeReference arrayTypeReference);

        void VisitAttributeGroup(IAttributeGroup attributes);

        void VisitAttribute(IAttribute attribute);

        void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference);

        void VisitClass(IClass @class);

        void VisitPartialClassCollection(IPartialClassCollection classes);

        void VisitPartialClass(IPartialClass @class);

        void VisitClassAccessor(IClassAccessor accessor);

        void VisitClassConstructor(IClassConstructor constructor);

        void VisitClassEvent(IClassEvent @event);

        void VisitClassEventProperty(IClassEventProperty eventProperty);

        void VisitClassField(IClassField field);

        void VisitClassIndexer(IClassIndexer indexer);

        void VisitClassMethod(IClassMethod method);

        void VisitPartialMethodDefinition(IPartialMethodDefinition method);

        void VisitPartialMethodImplementation(IPartialMethodImplementation method);

        void VisitClassNestedClass(IClassNestedClass nestedClass);

        void VisitClassNestedPartialClass(IClassNestedPartialClass nestedClass);

        void VisitClassNestedDelegate(IClassNestedDelegate nestedDelegate);

        void VisitClassNestedEnum(IClassNestedEnum nestedEnum);

        void VisitClassNestedInterface(IClassNestedInterface @interface);

        void VisitClassNestedStruct(IClassNestedStruct nestedStruct);

        void VisitClassNestedPartialStruct(IClassNestedPartialStruct nestedStruct);

        void VisitClassProperty(IClassProperty property);

        void VisitClassReference(IClassReference classReference);

        void VisitConversionOperator(IConversionOperator conversionOperator);

        void VisitDelegate(IDelegate @delegate);

        void VisitDelegateReference(IDelegateReference delegateReference);

        void VisitDestructor(IDestructor destructor);
            
            
            

        Task VisitDocumentAsync(IDocument document);

        void VisitEnum(IEnum @enum);

        void VisitEnumMember(IEnumMember enumMember);

        void VisitEnumReference(IEnumReference enumReference);

        void VisitExplicitInterfaceEvent(IExplicitInterfaceEvent @event);

        void VisitExplicitInterfaceIndexer(IExplicitInterfaceIndexer indexer);

        void VisitExplicitInterfaceMethod(IExplicitInterfaceMethod method);

        void VisitExplicitInterfaceProperty(IExplicitInterfaceProperty property);

        void VisitGenericParameterDeclaration(IGenericParameterDeclaration genericParameterDeclaration);

        void VisitGenericParameterReference(IGenericParameterReference genericParameterReference);

        void VisitInterface(IInterface @interface);

        void VisitInterfaceAccessor(IInterfaceAccessor accessor);

        void VisitInterfaceEvent(IInterfaceEvent @event);

        void VisitInterfaceIndexer(IInterfaceIndexer indexer);

        void VisitInterfaceMethod(IInterfaceMethod method);

        void VisitInterfaceProperty(IInterfaceProperty property);

        void VisitInterfaceReference(IInterfaceReference interfaceReference);

        void VisitLoadedDocument(ILoadedDocument loadedDocument);

        void VisitMethodBody(IMethodBody methodBody);

        void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue);

        void VisitNamespace(INamespace @namespace);

        void VisitNestedEnumMember(INestedEnumMember nestedEnumMember);

        void VisitNestedTypeReference(INestedTypeReference nestedTypeReference);

        void VisitOperatorOverload(IOperatorOverload operatorOverload);

        void VisitParameter(IParameter parameter);

        void VisitConstructorParameter(IConstructorParameter parameter);

        void VisitDelegateParameter(IDelegateParameter parameter);

        void VisitExtensionParameter(IExtensionParameter parameter);

        void VisitIndexerParameter(IIndexerParameter parameter);

        void VisitMethodParameter(IMethodParameter parameter);

        void VisitOperatorParameter(IOperatorParameter parameter);
            
            

        Task VisitProjectAsync(IProject project);

        void VisitSealedClass(ISealedClass @class);

        void VisitSealedPartialClass(ISealedPartialClass @class);

        void VisitSealedClassEvent(ISealedClassEvent @event);

        void VisitSealedClassEventProperty(ISealedClassEventProperty eventProperty);

        void VisitSealedClassIndexer(ISealedClassIndexer indexer);

        void VisitSealedClassMethod(ISealedClassMethod method);

        void VisitSealedClassProperty(ISealedClassProperty property);
            
            
            
            

        Task VisitSolutionAsync(ISolution solution);

        void VisitStaticConstructor(IStaticConstructor staticConstructor);

        void VisitStaticClass(IStaticClass @class);

        void VisitStaticPartialClass(IStaticPartialClass @class);

        void VisitStaticClassAccessor(IStaticClassAccessor accessor);

        void VisitStaticClassEvent(IStaticClassEvent @event);

        void VisitStaticClassEventProperty(IStaticClassEventProperty eventProperty);

        void VisitStaticClassField(IStaticClassField field);

        void VisitStaticClassMethod(IStaticClassMethod method);

        void VisitStaticClassNestedClass(IStaticClassNestedClass nestedStaticClass);

        void VisitStaticClassNestedPartialClass(IStaticClassNestedPartialClass nestedStaticClass);

        void VisitStaticClassNestedDelegate(IStaticClassNestedDelegate nestedDelegate);

        void VisitStaticClassNestedEnum(IStaticClassNestedEnum nestedEnum);

        void VisitStaticClassNestedInterface(IStaticClassNestedInterface @interface);

        void VisitStaticClassNestedStruct(IStaticClassNestedStruct nestedStruct);

        void VisitStaticClassNestedPartialStruct(IStaticClassNestedPartialStruct nestedStruct);

        void VisitStaticClassProperty(IStaticClassProperty property);

        void VisitStruct(IStruct @struct);

        void VisitPartialStruct(IPartialStruct @struct);

        void VisitStructAccessor(IStructAccessor accessor);

        void VisitStructConstructor(IStructConstructor constructor);

        void VisitStructEvent(IStructEvent @event);

        void VisitStructEventProperty(IStructEventProperty eventProperty);

        void VisitStructField(IStructField field);

        void VisitStructIndexer(IStructIndexer indexer);

        void VisitStructMethod(IStructMethod method);

        void VisitStructNestedClass(IStructNestedClass nestedClass);

        void VisitStructNestedPartialClass(IStructNestedClass nestedClass);

        void VisitStructNestedDelegate(IStructNestedDelegate nestedDelegate);

        void VisitStructNestedEnum(IStructNestedEnum nestedEnum);

        void VisitStructNestedInterface(IStructNestedInterface @interface);

        void VisitStructNestedStruct(IStructNestedStruct nestedStruct);

        void VisitStructNestedPartialStruct(IStructNestedPartialStruct nestedStruct);

        void VisitStructProperty(IStructProperty property);

        void VisitStructReference(IStructReference structReference);

        void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue);

        void VisitUnspecifiedTypeReference(IUnspecifiedTypeReference unspecificTypeReference);

        void VisitUsingDirective(IUsingDirective usingDirective);

        void VisitConstructor(IConstructor constructor);

        void VisitEvent(IEvent @event);

        void VisitEventProperty(IEventProperty eventProperty);

        void VisitIndexer(IIndexer indexer);

        void VisitMethod(IMethod method);

        void VisitMethodWithBody(IMethod method);

        void VisitNestedClass(INestedClass nestedClass);

        void VisitDelegateType(IDelegateType @delegate);

        void VisitNestedDelegate(INestedDelegate nestedDelegate);

        void VisitNestedEnum(INestedEnum nestedEnum);

        void VisitNestedInterface(INestedInterface @interface);

        void VisitNestedStruct(INestedStruct nestedStruct);

        void VisitNullableTypeReference(INullableTypeReference reference);

        void VisitProperty(IProperty property);

        void VisitType(IType type);

        void VisitAbstractType(IAbstractType type);

        void VisitClassCollection(IClassCollection classCollection);

        void VisitClassConstant(IClassConstant classConstant);

        void VisitClassEventCollection(IClassEventCollection eventCollection);

        void VisitClassFieldCollection(IClassFieldCollection fieldCollection);

        void VisitClassIndexerCollection(IClassIndexerCollection indexerCollection);

        void VisitClassMethodCollection(IClassMethodCollection methodCollection);

        void VisitPartialClassMethodCollection(IPartialClassMethodCollection methodCollection);

        void VisitClassNestedAbstractClass(IClassNestedAbstractClass nestedClass);

        void VisitClassNestedAbstractPartialClass(IClassNestedAbstractPartialClass nestedClass);

        void VisitClassNestedClassCollection(IClassNestedClassCollection nestedClass);

        void VisitClassNestedSealedClass(IClassNestedSealedClass nestedClass);

        void VisitClassNestedSealedPartialClass(IClassNestedSealedPartialClass nestedClass);

        void VisitClassNestedStaticClass(IClassNestedStaticClass nestedClass);

        void VisitClassNestedStaticPartialClass(IClassNestedStaticPartialClass nestedClass);

        void VisitStaticClassNestedStaticClass(IStaticClassNestedStaticClass nestedClass);

        void VisitStaticClassNestedStaticPartialClass(IStaticClassNestedStaticPartialClass nestedClass);

        void VisitClassNestedStructCollection(IClassNestedStructCollection structCollection);

        void VisitClassPropertyCollection(IClassPropertyCollection propertyCollection);

        void VisitClassType(IClassType @class);

        void VisitConstant(IConstant constant);

        void VisitConstantGroup(IConstantGroup constantGroup);

        void VisitField(IField field);

        void VisitFieldGroup(IFieldGroup fieldGroup);

        void VisitNestedAbstractClass(INestedAbstractClass nestedClass);

        void VisitNestedClassCollection(INestedClassCollection classCollection);

        void VisitNestedSealedClass(INestedSealedClass nestedClass);

        void VisitNestedStaticClass(INestedStaticClass @class);

        void VisitNestedStructCollection(INestedStructCollection structCollection);

        void VisitSealedClassEventCollection(ISealedClassEventCollection eventCollection);

        void VisitSealedClassIndexerCollection(ISealedClassIndexerCollection indexerCollection);

        void VisitSealedClassMethodCollection(ISealedClassMethodCollection methodCollection);

        void VisitSealedPartialClassMethodCollection(ISealedPartialClassMethodCollection methodCollection);

        void VisitSealedClassPropertyCollection(ISealedClassPropertyCollection propertyCollection);

        void VisitSealedType(ISealedType type);

        void VisitStaticClassConstant(IStaticClassConstant constant);

        void VisitStaticClassEventCollection(IStaticClassEventCollection eventCollection);

        void VisitStaticClassFieldCollection(IStaticClassFieldCollection fieldCollection);

        void VisitStaticClassMethodCollection(IStaticClassMethodCollection methodCollection);

        void VisitStaticPartialClassMethodCollection(IStaticPartialClassMethodCollection methodCollection);

        void VisitStaticClassNestedAbstractClass(IStaticClassNestedAbstractClass nestedClass);

        void VisitStaticClassNestedAbstractPartialClass(IStaticClassNestedAbstractPartialClass nestedClass);

        void VisitStaticClassNestedClassCollection(IStaticClassNestedClassCollection classCollection);

        void VisitStaticClassNestedSealedClass(IStaticClassNestedSealedClass nestedClass);

        void VisitStaticClassNestedSealedPartialClass(IStaticClassNestedSealedPartialClass nestedClass);

        void VisitStaticClassNestedStructCollection(IStaticClassNestedStructCollection structCollection);

        void VisitStructCollection(IStructCollection structCollection);

        void VisitStructEventCollection(IStructEventCollection eventCollection);

        void VisitStructFieldCollection(IStructFieldCollection fieldCollection);

        void VisitStructIndexerCollection(IStructIndexerCollection indexerCollection);

        void VisitStructMethodCollection(IStructMethodCollection methodCollection);

        void VisitPartialStructMethodCollection(IPartialStructMethodCollection methodCollection);

        void VisitStructNestedAbstractClass(IStructNestedAbstractClass nestedClass);

        void VisitStructNestedAbstractPartialClass(IStructNestedAbstractPartialClass nestedClass);

        void VisitStructNestedClassCollection(IStructNestedClassCollection classCollection);

        void VisitStructNestedSealedClass(IStructNestedSealedClass nestedStruct);

        void VisitStructNestedSealedPartialClass(IStructNestedSealedPartialClass nestedStruct);

        void VisitStructNestedStaticClass(IStructNestedStaticClass nestedClass);

        void VisitStructNestedStaticPartialClass(IStructNestedStaticPartialClass nestedClass);

        void VisitStructNestedStructCollection(IStructNestedStructCollection structCollection);

        void VisitStructPropertyCollection(IStructPropertyCollection propertyCollection);

        void VisitStructType(IStructType type);

        void VisitStructConstant(IStructConstant constant);

        void VisitExtensionMethod(IExtensionMethod method);

        void VisitStaticType(IStaticType type);

        void VisitNestedStaticClassMethodCollection(INestedStaticClassMethodCollection methodCollection);

        void VisitNestedStaticPartialClassMethodCollection(INestedStaticPartialClassMethodCollection methodCollection);

        void VisitTypeReference(ITypeReference typeReference);
    }
}
