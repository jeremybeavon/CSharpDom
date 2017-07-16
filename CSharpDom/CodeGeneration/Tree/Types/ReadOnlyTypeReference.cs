using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Reflection;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyTypeReference : 
        IClassReference<ReadOnlyTypeReference>,
        IDelegateReference<ReadOnlyTypeReference>,
        IEnumReference,
        IGenericParameterReference,
        IInterfaceReference<ReadOnlyTypeReference>,
        IStructReference<ReadOnlyTypeReference>,
        IUnspecifiedTypeReference<ReadOnlyTypeReference>
    {
        private const ReadOnlyTypeReferenceType classType = ReadOnlyTypeReferenceType.Class;
        private const ReadOnlyTypeReferenceType delegateType = ReadOnlyTypeReferenceType.Delegate;
        private const ReadOnlyTypeReferenceType enumType = ReadOnlyTypeReferenceType.Enum;
        private const ReadOnlyTypeReferenceType genericParameterType = ReadOnlyTypeReferenceType.GenericParameter;
        private const ReadOnlyTypeReferenceType interfaceType = ReadOnlyTypeReferenceType.Interface;
        private const ReadOnlyTypeReferenceType structType = ReadOnlyTypeReferenceType.Struct;
        private const ReadOnlyTypeReferenceType reflectionType = ReadOnlyTypeReferenceType.Reflection;
        private const ReadOnlyTypeReferenceType unspecifiedType = ReadOnlyTypeReferenceType.Unspecified;
        //private static readonly A

        private static readonly Func<ReadOnlyTypeReference, bool>[] nameAndTypeBuilders =
            new Func<ReadOnlyTypeReference, bool>[]
            {
                type => Initialize(type, !string.IsNullOrWhiteSpace(type.type.TypeText), unspecifiedType, () => type.type.TypeText),
                type => Initialize(type, type.type.Class != null, classType, () => type.type.Class.Name),
                type => Initialize(type, type.type.ClassNestedClass != null, classType, () => type.type.ClassNestedClass.Name),
                type => Initialize(type, type.type.ClassNestedDelegate != null, delegateType, () => type.type.ClassNestedDelegate.Name),
                type => Initialize(type, type.type.ClassNestedEnum != null, enumType, () => type.type.ClassNestedEnum.Name),
                type => Initialize(type, type.type.ClassNestedInterface != null, interfaceType, () => type.type.ClassNestedInterface.Name),
                type => Initialize(type, type.type.ClassNestedStruct != null, classType, () => type.type.ClassNestedStruct.Name),
                type => Initialize(type, type.type.Delegate != null, delegateType, () => type.type.Delegate.Name),
                type => Initialize(type, type.type.Enum != null, enumType, () => type.type.Enum.Name),
                type => Initialize(type, type.type.GenericParameter != null, genericParameterType, () => type.type.GenericParameter.Name),
                type => Initialize(type, type.type.Interface != null, interfaceType, () => type.type.Interface.Name),
                type => Initialize(type, type.type.Struct != null, structType, () => type.type.Struct.Name),
                type => Initialize(type, type.type.StructNestedClass != null, classType, () => type.type.StructNestedClass.Name),
                type => Initialize(type, type.type.StructNestedDelegate != null, delegateType, () => type.type.StructNestedDelegate.Name),
                type => Initialize(type, type.type.StructNestedEnum != null, enumType, () => type.type.StructNestedEnum.Name),
                type => Initialize(type, type.type.StructNestedInterface != null, interfaceType, () => type.type.StructNestedInterface.Name),
                type => Initialize(type, type.type.StructNestedStruct != null, structType, () => type.type.StructNestedStruct.Name),
                type => InitializeReflection(type)
            };

        private static readonly IDictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>> accept =
            new Dictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>>
            {
                { classType, (type, visitor) => visitor.VisitClassReference(type) },
                { delegateType, (type, visitor) => visitor.VisitDelegateReference(type) },
                { enumType, (type, visitor) => visitor.VisitEnumReference(type) },
                { genericParameterType, (type, visitor) => visitor.VisitGenericParameterReference(type) },
                { interfaceType, (type, visitor) => visitor.VisitInterfaceReference(type) },
                { structType, (type, visitor) => visitor.VisitStructReference(type) },
                { reflectionType, (type, visitor) => type.typeReferenceWithReflection.Accept(visitor) },
                { ReadOnlyTypeReferenceType.Unspecified, (type, visitor) => visitor.VisitUnspecifiedTypeReference(type) }
            };

        private static readonly IDictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>> acceptChildren =
            new Dictionary<ReadOnlyTypeReferenceType, Action<ReadOnlyTypeReference, IGenericVisitor>>
            {
                { classType, GenericVisitor.VisitClassReferenceChildren },
                { delegateType, GenericVisitor.VisitDelegateReferenceChildren },
                { enumType, (type, visitor) => { } },
                { genericParameterType, (type, visitor) => { } },
                { interfaceType, GenericVisitor.VisitInterfaceReferenceChildren },
                { structType, GenericVisitor.VisitStructReferenceChildren },
                { reflectionType, (type, visitor) => type.typeReferenceWithReflection.AcceptChildren(visitor) },
                { ReadOnlyTypeReferenceType.Unspecified, GenericVisitor.VisitUnspecifiedTypeReference }
            };

        private readonly TypeReference type;
        private readonly IReadOnlyList<ReadOnlyTypeReference> genericParameters;
        private ReadOnlyTypeReferenceType typeReferenceType;
        private string name;
        private ITypeReferenceWithReflection typeReferenceWithReflection;
        
        public ReadOnlyTypeReference(TypeReference typeReference)
        {
            type = typeReference;
            genericParameters = typeReference.GenericParameters.ToArray(parameter => new ReadOnlyTypeReference(parameter));
            foreach (Func<ReadOnlyTypeReference, bool> initializer in nameAndTypeBuilders)
            {
                if (initializer(this))
                {
                    break;
                }
            }
        }

        public IReadOnlyList<ReadOnlyTypeReference> GenericParameters
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
            Func<string> name)
        {
            if (isMatch)
            {
                typeReference.typeReferenceType = typeReferenceType;
                typeReference.name = name();
            }

            return isMatch;
        }

        private static bool InitializeReflection(ReadOnlyTypeReference type)
        {
            if (type.type.Type == null)
            {
                return false;
            }

            type.typeReferenceWithReflection = TypeReferenceWithReflectionFactory.CreateReference(type.type.Type);
            type.typeReferenceType = reflectionType;
            type.name = type.typeReferenceWithReflection.Type.Name;
            return true;
        }
    }
}
