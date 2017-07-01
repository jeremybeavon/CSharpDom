using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassBody :
        IType<
            AttributeGroupNotSupported,
            ReadOnlyGenericParameterDeclaration,
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
            ReadOnlyStaticConstructor>
    {
        public ReadOnlyClassBody(ClassBody classBody)
        {
            Classes = new ReadOnlyClassNestedClassCollection(classBody);
            Constructors = new ConstructorNotSupported[0];
            ConversionOperators = classBody.ConversionOperators
                .ToArray(conversionOperator => new ReadOnlyConversionOperator(conversionOperator));
            Delegates = classBody.NestedDelegates.ToArray(nestedDelegate => new ReadOnlyClassNestedDelegate(nestedDelegate));
            Enums = classBody.NestedEnums.ToArray(nestedEnum => new ReadOnlyClassNestedEnum(nestedEnum));
            Events = new ReadOnlyClassEventCollection(classBody);
            Fields = new ReadOnlyClassFieldCollection(classBody);
            Indexers = new ReadOnlyClassIndexerCollection(classBody);
            Interfaces = classBody.NestedInterfaces.ToArray(@interface => new ReadOnlyClassNestedInterface(@interface));
            Methods = new ReadOnlyClassMethodCollection(classBody);
            OperatorOverloads =
                classBody.BinaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator))
                .Concat(classBody.UnaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator)))
                .ToArray();
            Properties = new ReadOnlyClassPropertyCollection(classBody);
            if (classBody.StaticConstructor != null)
            {
                StaticConstructor = new ReadOnlyStaticConstructor(classBody.StaticConstructor);
            }

            Structs = new ReadOnlyClassNestedStructCollection(classBody);
        }

        public IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ReadOnlyClassNestedClassCollection Classes { get; private set; }

        public IReadOnlyCollection<ConstructorNotSupported> Constructors { get; private set; }

        public IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassNestedDelegate> Delegates { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassNestedEnum> Enums { get; private set; }

        public ReadOnlyClassEventCollection Events { get; private set; }
        
        public ReadOnlyClassFieldCollection Fields { get; private set; }

        public IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<ReadOnlyInterfaceReference> ImplementedInterfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ReadOnlyClassIndexerCollection Indexers { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassNestedInterface> Interfaces { get; private set; }

        public ReadOnlyClassMethodCollection Methods { get; private set; }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads { get; private set; }

        public ReadOnlyClassPropertyCollection Properties { get; private set; }

        public ReadOnlyStaticConstructor StaticConstructor { get; set; }

        public ReadOnlyClassNestedStructCollection Structs { get; private set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitType(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitTypeChildren(this, visitor);
        }
    }
}
