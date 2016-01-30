using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyTypeReference : 
        IClassReference<ReadOnlyGenericParameter>,
        IDelegateReference<ReadOnlyGenericParameter>,
        IEnumReference,
        IGenericParameterReference,
        IInterfaceReference<ReadOnlyGenericParameter>,
        IStructReference<ReadOnlyGenericParameter>,
        IUnspecifiedTypeReference<ReadOnlyGenericParameter>
    {
        private const ReadOnlyTypeReferenceType classType = ReadOnlyTypeReferenceType.Class;
        private const ReadOnlyTypeReferenceType delegateType = ReadOnlyTypeReferenceType.Delegate;
        private const ReadOnlyTypeReferenceType enumType = ReadOnlyTypeReferenceType.Enum;
        private const ReadOnlyTypeReferenceType genericParameterType = ReadOnlyTypeReferenceType.GenericParameter;
        private const ReadOnlyTypeReferenceType interfaceType = ReadOnlyTypeReferenceType.Interface;
        private const ReadOnlyTypeReferenceType structType = ReadOnlyTypeReferenceType.Struct;
        private const ReadOnlyTypeReferenceType unspecifiedType = ReadOnlyTypeReferenceType.Unspecified;
        //private static readonly A

        private static readonly Func<ReadOnlyTypeReference, bool>[] nameAndTypeBuilders =
            new Func<ReadOnlyTypeReference, bool>[]
            {
                type => Initialize(type, !string.IsNullOrWhiteSpace(type.type.TypeText), unspecifiedType, type.type.TypeText),
                type => Initialize(type, type.type.Class != null, classType, type.type.Class.Name),
                type => Initialize(type, type.type.ClassNestedClass != null, classType, type.type.ClassNestedClass.Name),
                type => Initialize(type, type.type.ClassNestedDelegate != null, delegateType, type.type.ClassNestedDelegate.Name),
                type => Initialize(type, type.type.ClassNestedEnum != null, enumType, type.type.ClassNestedEnum.Name),
                type => Initialize(type, type.type.ClassNestedInterface != null, interfaceType, type.type.ClassNestedInterface.Name),
                type => Initialize(type, type.type.ClassNestedStruct != null, classType, type.type.ClassNestedStruct.Name),
                type => Initialize(type, type.type.Delegate != null, delegateType, type.type.Delegate.Name),
                type => Initialize(type, type.type.Enum != null, enumType, type.type.Enum.Name),
                type => Initialize(type, type.type.GenericParameter != null, genericParameterType, type.type.GenericParameter.Name),
                type => Initialize(type, type.type.Interface != null, interfaceType, type.type.Interface.Name),
                type => Initialize(type, type.type.Struct != null, structType, type.type.Struct.Name),
                type => Initialize(type, type.type.StructNestedClass != null, classType, type.type.StructNestedClass.Name),
                type => Initialize(type, type.type.StructNestedDelegate != null, delegateType, type.type.StructNestedDelegate.Name),
                type => Initialize(type, type.type.StructNestedEnum != null, enumType, type.type.StructNestedEnum.Name),
                type => Initialize(type, type.type.StructNestedInterface != null, interfaceType, type.type.StructNestedInterface.Name),
                type => Initialize(type, type.type.StructNestedStruct != null, structType, type.type.StructNestedStruct.Name),
                type => Initialize(type, type.type.Type != null, unspecifiedType, type.type.Type.Name),
            };

        private static readonly IDictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>> accept =
            new Dictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>>
            {
                { ReadOnlyTypeReferenceType.Class, (type, visitor) => visitor.VisitClassReference(type) },
                { ReadOnlyTypeReferenceType.Delegate, (type, visitor) => visitor.VisitDelegateReference(type) },
                { ReadOnlyTypeReferenceType.Enum, (type, visitor) => visitor.VisitEnumReference(type) },
                { ReadOnlyTypeReferenceType.GenericParameter, (type, visitor) => visitor.VisitGenericParameterReference(type) },
                { ReadOnlyTypeReferenceType.Interface, (type, visitor) => visitor.VisitInterfaceReference(type) },
                { ReadOnlyTypeReferenceType.Struct, (type, visitor) => visitor.VisitStructReference(type) },
                { ReadOnlyTypeReferenceType.Unspecified, (type, visitor) => visitor.VisitUnspecifiedTypeReference(type) }
            };

        private static readonly IDictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>> acceptChildren =
            new Dictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>>
            {
                { ReadOnlyTypeReferenceType.Class, GenericVisitor.VisitClassReferenceChildren },
                { ReadOnlyTypeReferenceType.Delegate, GenericVisitor.VisitDelegateReferenceChildren },
                { ReadOnlyTypeReferenceType.Enum, (type, visitor) => { } },
                { ReadOnlyTypeReferenceType.GenericParameter, (type, visitor) => { } },
                { ReadOnlyTypeReferenceType.Interface, GenericVisitor.VisitInterfaceReferenceChildren },
                { ReadOnlyTypeReferenceType.Struct, GenericVisitor.VisitStructReferenceChildren },
                { ReadOnlyTypeReferenceType.Unspecified, GenericVisitor.VisitUnspecifiedTypeReference }
            };

        private readonly TypeReference type;
        private readonly IReadOnlyList<ReadOnlyGenericParameter> genericParameters;
        private ReadOnlyTypeReferenceType typeReferenceType;
        private string name;
        
        public ReadOnlyTypeReference(TypeReference typeReference)
        {
            type = typeReference;
            genericParameters = ReadOnlyGenericParameter.Create(typeReference.GenericParameters);
            foreach (Func<ReadOnlyTypeReference, bool> initializer in nameAndTypeBuilders)
            {
                if (initializer(this))
                {
                    break;
                }
            }
        }

        public IReadOnlyList<ReadOnlyGenericParameter> GenericParameters
        {
            get { return genericParameters; }
        }

        public string Name
        {
            get { return name; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            accept[typeReferenceType](this, visitor);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            acceptChildren[typeReferenceType](this, visitor);
        }

        private static bool Initialize(
            ReadOnlyTypeReference typeReference,
            bool isMatch,
            ReadOnlyTypeReferenceType typeReferenceType,
            string name)
        {
            if (isMatch)
            {
                typeReference.typeReferenceType = typeReferenceType;
                typeReference.name = name;
            }

            return isMatch;
        }
    }
}
