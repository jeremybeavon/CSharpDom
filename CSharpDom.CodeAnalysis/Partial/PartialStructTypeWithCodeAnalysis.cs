using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class PartialStructTypeWithCodeAnalysis<TStruct> :
        EditableStructType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            PartialStructEventCollectionWithCodeAnalysis,
            PartialStructPropertyCollectionWithCodeAnalysis,
            PartialStructIndexerCollectionWithCodeAnalysis,
            PartialStructMethodCollectionWithCodeAnalysis,
            PartialStructFieldCollectionWithCodeAnalysis,
            PartialStructConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            PartialStructNestedClassCollectionWithCodeAnalysis,
            PartialStructNestedDelegateWithCodeAnalysis,
            PartialStructNestedEnumWithCodeAnalysis,
            PartialStructNestedInterfaceWithCodeAnalysis,
            PartialStructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly IMemberList members;
        private readonly PartialStructNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            StructConstructorWithCodeAnalysis,
            PartialStructConstructorWithCodeAnalysis> constructors;
        private readonly WrappedCollection<
            StructNestedDelegateWithCodeAnalysis,
            PartialStructNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            StructNestedEnumWithCodeAnalysis,
            PartialStructNestedEnumWithCodeAnalysis> enums;
        private readonly PartialStructEventCollectionWithCodeAnalysis events;
        private readonly PartialStructFieldCollectionWithCodeAnalysis fields;
        private readonly PartialStructIndexerCollectionWithCodeAnalysis indexers;
        private readonly WrappedCollection<
            StructNestedInterfaceWithCodeAnalysis,
            PartialStructNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly PartialStructMethodCollectionWithCodeAnalysis methods;
        private readonly PartialStructPropertyCollectionWithCodeAnalysis properties;
        private readonly PartialStructNestedStructCollectionWithCodeAnalysis structs;

        internal PartialStructTypeWithCodeAnalysis(InternalNestedStructWithCodeAnalysis<TStruct> structType)
            : this(structType.InternalStruct)
        {
        }

        internal PartialStructTypeWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> classType)
        {
            this.structType = classType;
            members = classType.Members;
            classes = new PartialStructNestedClassCollectionWithCodeAnalysis(classType.Classes);
            constructors = new WrappedCollection<StructConstructorWithCodeAnalysis, PartialStructConstructorWithCodeAnalysis>(
                classType.Constructors,
                constructor => new PartialStructConstructorWithCodeAnalysis(constructor),
                constructor => constructor.Constructor,
                value => classType.Constructors = value);
            delegates = new WrappedCollection<StructNestedDelegateWithCodeAnalysis, PartialStructNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new PartialStructNestedDelegateWithCodeAnalysis(parent),
                child => child.Delegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<StructNestedEnumWithCodeAnalysis, PartialStructNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new PartialStructNestedEnumWithCodeAnalysis(parent),
                child => child.Enum,
                value => classType.Enums = value);
            events = new PartialStructEventCollectionWithCodeAnalysis(classType.Events);
            fields = new PartialStructFieldCollectionWithCodeAnalysis(classType.Fields);
            indexers = new PartialStructIndexerCollectionWithCodeAnalysis(classType.Indexers);
            interfaces = new WrappedCollection<StructNestedInterfaceWithCodeAnalysis, PartialStructNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new PartialStructNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            methods = new InternalPartialStructMethodCollectionWithCodeAnalysis<TStruct>(classType);
            properties = new PartialStructPropertyCollectionWithCodeAnalysis(classType.Properties);
            structs = new PartialStructNestedStructCollectionWithCodeAnalysis(classType.Structs);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return structType.Attributes; }
            set { structType.Attributes = value; }
        }
        
        public override PartialStructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.StaticClasses), value.StaticClasses.Select(item => item.Syntax)));
            }
        }

        public override ICollection<PartialStructConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { constructors.Replace(value); }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return structType.ConversionOperators; }
            set { structType.ConversionOperators = value; }
        }

        public override ICollection<PartialStructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { delegates.Replace(value); }
        }
        
        public override ICollection<PartialStructNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { enums.Replace(value); }
        }

        public override PartialStructEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.ExplicitInterfaceEvents), value.ExplicitInterfaceEvents.Select(@event => @event.Syntax)));
            }
        }

        public override PartialStructFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(fields.Constants), value.Constants.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(fields.Fields), value.Fields.Select(item => item.Syntax)));
            }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return structType.GenericParameters; }
            set { structType.GenericParameters = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return structType.ImplementedInterfaces; }
            set { structType.ImplementedInterfaces = value; }
        }

        public override PartialStructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax)));
            }
        }

        public override ICollection<PartialStructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.Replace(value); }
        }

        public override PartialStructMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set { structType.Members.Replace(value); }
        }

        public override string Name
        {
            get { return structType.Name; }
            set { structType.Name = value; }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return structType.OperatorOverloads; }
            set { structType.OperatorOverloads = value; }
        }

        public override PartialStructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(property => property.Syntax)));
            }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return structType.StaticConstructor; }
            set { structType.StaticConstructor = value; }
        }

        public override PartialStructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }
    }
}
