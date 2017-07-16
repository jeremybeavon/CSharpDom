using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassNestedClass :
        AbstractClassNestedClass<
            AttributeGroupNotSupported,
            IClassType,
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
        private readonly ClassNestedClass nestedClass;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly ReadOnlyClassReference baseClass;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyClassBody body;

        public ReadOnlyClassNestedClass(ClassNestedClass nestedClass)
        {
            this.nestedClass = nestedClass;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(nestedClass.GenericParameters);
            if (nestedClass.BaseClass != null)
            {
                baseClass = new ReadOnlyClassReference(nestedClass.BaseClass);
            }

            implementedInterfaces = ReadOnlyInterfaceReference.Create(nestedClass.Interfaces);
            body = new ReadOnlyClassBody(nestedClass.Body);
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

        public override IClassType DeclaringType
        {
            get { return null; }
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
            get { return nestedClass.Name; }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override ReadOnlyClassPropertyCollection Properties
        {
            get { return body.Properties; }
        }

        public override ReadOnlyClassNestedStructCollection Structs
        {
            get { return body.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Visibility; }
        }
        
        public override ReadOnlyStaticConstructor StaticConstructor
        {
            get { return body.StaticConstructor; }
        }
    }
}
