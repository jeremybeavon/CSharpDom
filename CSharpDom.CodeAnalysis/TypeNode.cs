using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class TypeNode<TDeclarationNode, TDeclaration> : BasicTypeNode<TDeclarationNode, TDeclaration>,
        ICompositeType
        where TDeclarationNode : MemberContainer<TDeclaration>
        where TDeclaration : TypeDeclarationSyntax
    {
        private IReadOnlyCollection<FieldNode> fields;
        private IReadOnlyCollection<ConstructorNode> constructors;
        private IReadOnlyCollection<EventPropertyNode> eventProperties;
        private IReadOnlyCollection<OperatorOverloadNode> operatorOverloads;
        private IReadOnlyCollection<ConversionOperatorNode> conversionOperators;
        private IReadOnlyCollection<ClassNode> classes;
        private IReadOnlyCollection<DelegateNode> delegates;
        private IReadOnlyCollection<EnumNode> enums;
        private IReadOnlyCollection<InterfaceNode> interfaces;
        private IReadOnlyCollection<StructNode> structs;

        protected TypeNode(TDeclaration declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public IReadOnlyCollection<FieldNode> Fields
        {
            get
            {
                if (fields == null)
                {
                    fields = CreateReadOnlyCollection(declaration => declaration.Fields);
                }

                return fields;
            }
        }

        public IReadOnlyCollection<ConstructorNode> Constructors
        {
            get
            {
                if (constructors == null)
                {
                    constructors = CreateReadOnlyCollection(declaration => declaration.Constructors);
                }

                return constructors;
            }
        }

        public IReadOnlyCollection<EventPropertyNode> EventProperties
        {
            get
            {
                if (eventProperties == null)
                {
                    eventProperties = CreateReadOnlyCollection(declaration => declaration.EventProperties);
                }

                return eventProperties;
            }
        }

        public IReadOnlyCollection<OperatorOverloadNode> OperatorOverloads
        {
            get
            {
                if (operatorOverloads == null)
                {
                    operatorOverloads = CreateReadOnlyCollection(declaration => declaration.OperatorOverloads);
                }

                return operatorOverloads;
            }
        }

        public IReadOnlyCollection<ConversionOperatorNode> ConversionOperators
        {
            get
            {
                if (conversionOperators == null)
                {
                    conversionOperators = CreateReadOnlyCollection(declaration => declaration.ConversionOperators);
                }

                return conversionOperators;
            }
        }

        public IReadOnlyCollection<ClassNode> Classes
        {
            get
            {
                if (classes == null)
                {
                    classes = CreateReadOnlyCollection(declaration => declaration.Classes);
                }

                return classes;
            }
        }

        public IReadOnlyCollection<DelegateNode> Delegates
        {
            get
            {
                if (delegates == null)
                {
                    delegates = CreateReadOnlyCollection(declaration => declaration.Delegates);
                }

                return delegates;
            }
        }

        public IReadOnlyCollection<EnumNode> Enums
        {
            get
            {
                if (enums == null)
                {
                    enums = CreateReadOnlyCollection(declaration => declaration.Enums);
                }

                return enums;
            }
        }

        public IReadOnlyCollection<InterfaceNode> Interfaces
        {
            get
            {
                if (interfaces == null)
                {
                    interfaces = CreateReadOnlyCollection(declaration => declaration.Interfaces);
                }

                return interfaces;
            }
        }

        public IReadOnlyCollection<StructNode> Structs
        {
            get
            {
                if (structs == null)
                {
                    structs = CreateReadOnlyCollection(declaration => declaration.Structs);
                }

                return structs;
            }
        }
    }
}
