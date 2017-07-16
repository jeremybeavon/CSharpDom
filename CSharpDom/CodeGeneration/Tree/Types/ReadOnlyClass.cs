using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClass :
        AbstractClass<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyClassReference,
            ReadOnlyInterfaceReference,
            ReadOnlyClassEventCollection,
            ReadOnlyClassPropertyCollection,
            ReadOnlyClassIndexerCollection,
            ReadOnlyClassMethodCollection,
            ReadOnlyClassFieldCollection,
            ConstructorNotSupported,
            ReadOnlyOperatorOverload,
            ReadOnlyConversionOperator,
            ReadOnlyClassNestedClassCollection,
            ReadOnlyClassNestedDelegate,
            ReadOnlyClassNestedEnum,
            ReadOnlyClassNestedInterface,
            ReadOnlyClassNestedStructCollection,
            ReadOnlyStaticConstructor,
            DestructorNotSupported>
    {
        private readonly Class @class;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly ReadOnlyClassReference baseClass;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyClassBody body;

        public ReadOnlyClass(Class @class)
        {
            this.@class = @class;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(@class.GenericParameters);
            if (@class.BaseClass != null)
            {
                baseClass = new ReadOnlyClassReference(@class.BaseClass);
            }

            implementedInterfaces = ReadOnlyInterfaceReference.Create(@class.Interfaces);
            body = new ReadOnlyClassBody(@class.Body);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyClassReference BaseClass
        {
            get { return baseClass; }
        }

        public override ReadOnlyClassNestedClassCollection Classes
        {
            get { return body.Classes; }
        }

        public override IReadOnlyCollection<ConstructorNotSupported> Constructors
        {
            get { return body.Constructors; }
        }

        public override IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators
        {
            get { return body.ConversionOperators; }
        }
        
        public override IReadOnlyCollection<ReadOnlyClassNestedDelegate> Delegates
        {
            get { return body.Delegates; }
        }

        public override DestructorNotSupported Destructor
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ReadOnlyClassNestedEnum> Enums
        {
            get { return body.Enums; }
        }
        
        public override ReadOnlyClassEventCollection Events
        {
            get { return body.Events; }
        }

        public override ReadOnlyClassFieldCollection Fields
        {
            get { return body.Fields; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceReference> ImplementedInterfaces
        {
            get { return implementedInterfaces; }
        }

        public override ReadOnlyClassIndexerCollection Indexers
        {
            get { return body.Indexers; }
        }
        
        public override IReadOnlyCollection<ReadOnlyClassNestedInterface> Interfaces
        {
            get { return body.Interfaces; }
        }

        public override ReadOnlyClassMethodCollection Methods
        {
            get { return body.Methods; }
        }

        public override string Name
        {
            get { return @class.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override ReadOnlyClassPropertyCollection Properties
        {
            get { return body.Properties; }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override ReadOnlyClassNestedStructCollection Structs
        {
            get { return body.Structs; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @class.Visibility; }
        }
        
        public override ReadOnlyStaticConstructor StaticConstructor
        {
            get { return body.StaticConstructor; }
        }

        public override DocumentNotSupported Document
        {
            get { return new DocumentNotSupported(); }
        }
    }
}
