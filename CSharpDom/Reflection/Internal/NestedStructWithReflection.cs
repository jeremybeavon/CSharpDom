using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedStructWithReflection :
        AbstractNestedStruct<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            StructEventCollectionWithReflection,
            StructPropertyCollectionWithReflection,
            StructIndexerCollectionWithReflection,
            StructMethodCollectionWithReflection,
            StructFieldCollectionWithReflection,
            StructConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            StructNestedClassCollectionWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceCollectionWithReflection,
            StructNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>,
        ITypeWithReflection
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Type type;
        private readonly StructTypeWithReflection typeWithReflection;

        internal NestedStructWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            typeWithReflection = new StructTypeWithReflection(this);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override StructNestedClassCollectionWithReflection Classes
        {
            get { return typeWithReflection.Classes; }
        }

        public override IReadOnlyCollection<StructConstructorWithReflection> Constructors
        {
            get { return typeWithReflection.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return typeWithReflection.ConversionOperators; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyCollection<StructNestedDelegateWithReflection> Delegates
        {
            get { return typeWithReflection.Delegates; }
        }
        
        public override IReadOnlyCollection<StructNestedEnumWithReflection> Enums
        {
            get { return typeWithReflection.Enums; }
        }
        
        public override StructEventCollectionWithReflection Events
        {
            get { return typeWithReflection.Events; }
        }

        public override StructFieldCollectionWithReflection Fields
        {
            get { return typeWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return typeWithReflection.GenericParameters; }
        }

        public override StructIndexerCollectionWithReflection Indexers
        {
            get { return typeWithReflection.Indexers; }
        }

        public override StructNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }
        
        public override StructMethodCollectionWithReflection Methods
        {
            get { return typeWithReflection.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return typeWithReflection.OperatorOverloads; }
        }

        public override StructPropertyCollectionWithReflection Properties
        {
            get { return typeWithReflection.Properties; }
        }

        public override StructNestedStructCollectionWithReflection Structs
        {
            get { return typeWithReflection.Structs; }
        }
        
        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return typeWithReflection.ImplementedInterfaces; }
        }

        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }
    }
}
