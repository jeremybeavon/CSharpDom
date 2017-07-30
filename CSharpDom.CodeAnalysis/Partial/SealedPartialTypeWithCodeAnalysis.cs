using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class SealedPartialTypeWithCodeAnalysis<TClass> :
        EditableSealedType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedPartialClassEventCollectionWithCodeAnalysis,
            SealedPartialClassPropertyCollectionWithCodeAnalysis,
            SealedPartialClassIndexerCollectionWithCodeAnalysis,
            SealedPartialClassMethodCollectionWithCodeAnalysis,
            SealedPartialClassFieldCollectionWithCodeAnalysis,
            SealedPartialClassConstructorWithCodeAnalysis,
            SealedPartialClassOperatorOverloadWithCodeAnalysis,
            SealedPartialClassConversionOperatorWithCodeAnalysis,
            SealedPartialClassNestedClassCollectionWithCodeAnalysis,
            SealedPartialClassNestedDelegateWithCodeAnalysis,
            SealedPartialClassNestedEnumWithCodeAnalysis,
            SealedPartialClassNestedInterfaceWithCodeAnalysis,
            SealedPartialClassNestedStructCollectionWithCodeAnalysis,
            SealedPartialClassStaticConstructorWithCodeAnalysis,
            SealedPartialClassDestructorWithCodeAnalysis>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalSealedTypeWithCodeAnalysis<TClass> classType;
        private readonly IMemberList members;
        private readonly SealedPartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            SealedClassConstructorWithCodeAnalysis,
            SealedPartialClassConstructorWithCodeAnalysis> constructors;
        private readonly WrappedCollection<
            SealedClassConversionOperatorWithCodeAnalysis,
            SealedPartialClassConversionOperatorWithCodeAnalysis> conversionOperators;
        private readonly WrappedCollection<
            SealedClassNestedDelegateWithCodeAnalysis,
            SealedPartialClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            SealedClassNestedEnumWithCodeAnalysis,
            SealedPartialClassNestedEnumWithCodeAnalysis> enums;
        private readonly SealedPartialClassEventCollectionWithCodeAnalysis events;
        private readonly SealedPartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly SealedPartialClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly WrappedCollection<
            SealedClassNestedInterfaceWithCodeAnalysis,
            SealedPartialClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly SealedPartialClassMethodCollectionWithCodeAnalysis methods;
        private readonly WrappedCollection<
            SealedClassOperatorOverloadWithCodeAnalysis,
            SealedPartialClassOperatorOverloadWithCodeAnalysis> operatorOverloads;
        private readonly SealedPartialClassPropertyCollectionWithCodeAnalysis properties;
        private readonly SealedPartialClassNestedStructCollectionWithCodeAnalysis structs;

        internal SealedPartialTypeWithCodeAnalysis(InternalNestedSealedClassWithCodeAnalysis<TClass> classType)
            : this(classType.InternalSealedType)
        {
        }

        internal SealedPartialTypeWithCodeAnalysis(InternalSealedTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            members = classType.Type.Members;
            classes = new SealedPartialClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            constructors = new WrappedCollection<SealedClassConstructorWithCodeAnalysis, SealedPartialClassConstructorWithCodeAnalysis>(
                classType.Constructors,
                constructor => new SealedPartialClassConstructorWithCodeAnalysis(constructor),
                constructor => constructor.Constructor,
                value => classType.Constructors = value);
            conversionOperators = new WrappedCollection<SealedClassConversionOperatorWithCodeAnalysis, SealedPartialClassConversionOperatorWithCodeAnalysis>(
                classType.ConversionOperators,
                parent => new SealedPartialClassConversionOperatorWithCodeAnalysis(parent),
                child => child.ConversionOperator,
                value => classType.ConversionOperators = value);
            delegates = new WrappedCollection<SealedClassNestedDelegateWithCodeAnalysis, SealedPartialClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new SealedPartialClassNestedDelegateWithCodeAnalysis(parent),
                child => child.Delegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<SealedClassNestedEnumWithCodeAnalysis, SealedPartialClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new SealedPartialClassNestedEnumWithCodeAnalysis(parent),
                child => child.Enum,
                value => classType.Enums = value);
            events = new SealedPartialClassEventCollectionWithCodeAnalysis(classType.Events);
            fields = new SealedPartialClassFieldCollectionWithCodeAnalysis(classType.Fields);
            indexers = new SealedPartialClassIndexerCollectionWithCodeAnalysis(classType.Indexers);
            interfaces = new WrappedCollection<SealedClassNestedInterfaceWithCodeAnalysis, SealedPartialClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new SealedPartialClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            methods = new InternalSealedPartialClassMethodCollectionWithCodeAnalysis<TClass>(classType.Type);
            operatorOverloads = new WrappedCollection<SealedClassOperatorOverloadWithCodeAnalysis, SealedPartialClassOperatorOverloadWithCodeAnalysis>(
                classType.OperatorOverloads,
                parent => new SealedPartialClassOperatorOverloadWithCodeAnalysis(parent),
                child => child.OperatorOverload,
                value => classType.OperatorOverloads = value);
            properties = new SealedPartialClassPropertyCollectionWithCodeAnalysis(classType.Properties);
            structs = new SealedPartialClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return classType.BaseClass; }
            set { classType.BaseClass = value; }
        }

        public override SealedPartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.StaticClasses), value.StaticClasses.Select(item => item.Syntax)));
            }
        }

        public override ICollection<SealedPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { constructors.Replace(value); }
        }

        public override ICollection<SealedPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { conversionOperators.Replace(value); }
        }

        public override ICollection<SealedPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { delegates.Replace(value); }
        }

        public override SealedPartialClassDestructorWithCodeAnalysis Destructor
        {
            get
            {
                SealedClassDestructorWithCodeAnalysis destructor = classType.Destructor;
                return destructor == null ? null : new SealedPartialClassDestructorWithCodeAnalysis(destructor);
            }
            set { classType.Destructor = value?.Destructor; }
        }

        public override ICollection<SealedPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { enums.Replace(value); }
        }

        public override SealedPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(events.Events), value.Events.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.EventProperties), value.EventProperties.Select(@event => @event.Syntax)),
                    new MemberListSyntax(nameof(events.ExplicitInterfaceEvents), value.ExplicitInterfaceEvents.Select(@event => @event.Syntax)));
            }
        }

        public override SealedPartialClassFieldCollectionWithCodeAnalysis Fields
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
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return classType.ImplementedInterfaces; }
            set { classType.ImplementedInterfaces = value; }
        }

        public override SealedPartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax)));
            }
        }

        public override ICollection<SealedPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { interfaces.Replace(value); }
        }

        public override SealedPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set { classType.Type.Members.Replace(value); }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<SealedPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { operatorOverloads.Replace(value); }
        }

        public override SealedPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(property => property.Syntax)));
            }
        }

        public override SealedPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get
            {
                SealedClassStaticConstructorWithCodeAnalysis constructor = classType.StaticConstructor;
                return constructor == null ? null : new SealedPartialClassStaticConstructorWithCodeAnalysis(constructor);
            }
            set { classType.StaticConstructor = value?.StaticConstructor; }
        }

        public override SealedPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(nameof(structs.Structs), value.Structs.Select(item => item.Syntax)); }
        }
    }
}
