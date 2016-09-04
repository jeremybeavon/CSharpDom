using System;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassTypeWithCodeAnalysis :
        EditableClassType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ClassEventCollectionWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            ClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            IClassNestedClassCollection,
            IClassNestedDelegate,
            IClassNestedEnum,
            IClassNestedInterfaceCollection,
            IClassNestedStructCollection,
            DestructorWithCodeAnalysis,
            IStaticConstructor>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node;
        private readonly AttributeListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> attributes;
        private readonly ClassMemberListWrapper<
            ConstructorWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            ConstructorDeclarationSyntax> constructors;
        private readonly SimpleClassMemberListWrapper<
            ConversionOperatorWithCodeAnalysis,
            ConversionOperatorDeclarationSyntax> conversionOperators;
        private readonly ClassEventCollectionWithCodeAnalysis events;
        private readonly ClassFieldCollectionWithCodeAnalysis fields;
        private readonly GenericParameterDeclarationListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> genericParameters;
        private readonly ClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly ClassMethodCollectionWithCodeAnalysis methods;
        private readonly SimpleClassMemberListWrapper<
            OperatorOverloadWithCodeAnalysis,
            OperatorDeclarationSyntax> operatorOverloads;
        private readonly ClassPropertyCollectionWithCodeAnalysis properties;
        private readonly CombinedMemberList<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> members;

        private ClassTypeWithCodeAnalysis()
        {
            node = new Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            constructors = new ClassMemberListWrapper<ConstructorWithCodeAnalysis, ClassConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                node,
                parent => new ClassConstructorWithCodeAnalysis(parent),
                (child, parent) => child.Constructor.ClassParent = parent);
            conversionOperators = new SimpleClassMemberListWrapper<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                node,
                parent => new ConversionOperatorWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            events = new ClassEventCollectionWithCodeAnalysis(this);
            fields = new ClassFieldCollectionWithCodeAnalysis(this);
            genericParameters = new GenericParameterDeclarationListWrapper<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            indexers = new ClassIndexerCollectionWithCodeAnalysis(this);
            methods = new ClassMethodCollectionWithCodeAnalysis(this);
            operatorOverloads = new SimpleClassMemberListWrapper<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                node,
                parent => new OperatorOverloadWithCodeAnalysis(parent),
                (child, parent) => child.ClassParent = parent);
            properties = new ClassPropertyCollectionWithCodeAnalysis(this);
            members = new CombinedMemberList<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(fields.Constants), () => fields.Constants.Select(constant => constant.Syntax) },
                { nameof(fields.Fields), () => fields.Fields.Select(field => field.Syntax) },
                { nameof(events.Events), () => events.Events.Select(@event => @event.Syntax) },
                { nameof(events.EventProperties), () => events.EventProperties.Select(@event => @event.Syntax) },
                { nameof(events.ExplicitInterfaceEvents), () => events.ExplicitInterfaceEvents.Select(@event => @event.Syntax) },
                { nameof(Constructors), () => constructors.Select(constructor => constructor.Syntax) },
                { nameof(properties.Properties), () => properties.Properties.Select(property => property.Syntax) },
                { nameof(properties.ExplicitInterfaceProperties), () => properties.ExplicitInterfaceProperties.Select(property => property.Syntax) },
                { nameof(indexers.Indexers), () => indexers.Indexers.Select(indexer => indexer.Syntax) },
                { nameof(indexers.ExplicitInterfaceIndexers), () => indexers.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax) },
                { nameof(methods.Methods), () => methods.Methods.Select(method => method.Syntax) },
                { nameof(methods.ExplicitInterfaceMethods), () => methods.ExplicitInterfaceMethods.Select(method => method.Syntax) },
                { nameof(OperatorOverloads), () => operatorOverloads.Select(@operator => @operator.Syntax) },
                { nameof(ConversionOperators), () => conversionOperators.Select(@operator => @operator.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override ICollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return constructors; }
            set { members.CombineList(nameof(Constructors), value.Select(constructor => constructor.Syntax)); }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return conversionOperators; }
            set { members.CombineList(nameof(ConversionOperators), value.Select(@operator => @operator.Syntax)); }
        }

        public override ClassEventCollectionWithCodeAnalysis Events
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

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(fields.Constants), value.Constants.Select(constant => constant.Syntax)),
                    new MemberListSyntax(nameof(fields.Fields), value.Fields.Select(field => field.Syntax)));
            }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { genericParameters.ReplaceList(value); }
        }

        public override ClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(indexers.Indexers), value.Indexers.Select(indexer => indexer.Syntax)),
                    new MemberListSyntax(nameof(indexers.ExplicitInterfaceIndexers), value.ExplicitInterfaceIndexers.Select(indexer => indexer.Syntax)));
            }
        }

        public override ClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(methods.Methods), value.Methods.Select(method => method.Syntax)),
                    new MemberListSyntax(nameof(methods.ExplicitInterfaceMethodList), value.ExplicitInterfaceMethods.Select(method => method.Syntax)));
            }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return operatorOverloads; }
            set { members.CombineList(nameof(OperatorOverloads), value.Select(@operator => @operator.Syntax)); }
        }

        public override ClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(properties.Properties), value.Properties.Select(property => property.Syntax)),
                    new MemberListSyntax(nameof(properties.ExplicitInterfaceProperties), value.Properties.Select(property => property.Syntax)));
            }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal CombinedMemberList<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> Members
        {
            get { return members; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> ConstructorList
        {
            get { return constructors; }
        }

        internal IChildCollection<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax> ConverisonOperatorList
        {
            get { return conversionOperators; }
        }

        internal IGenericParameterCollection GenericParameterList
        {
            get { return genericParameters; }
        }

        internal IChildCollection<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax> OperatorOverloadList
        {
            get { return operatorOverloads; }
        }
    }
}
