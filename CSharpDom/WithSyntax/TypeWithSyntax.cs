using System.Collections.Generic;

namespace CSharpDom.WithSyntax
{
    public abstract class TypeWithSyntax : BasicTypeWithSyntax
    {
        private readonly ITypeSyntax type;

        public TypeWithSyntax(ITypeSyntax type)
            : base(type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<NestedClassWithSyntax> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassWithSyntax, INestedClassSyntax>(
                    type.Classes,
                    @class => new NestedClassWithSyntax(@class));
            }
        }

        public IReadOnlyCollection<ConstructorWithSyntax> Constructors
        {
            get
            {
                return new ReadOnlyNodeCollection<ConstructorWithSyntax, IConstructorSyntax>(
                    type.Constructors,
                    constructor => new ConstructorWithSyntax(constructor));
            }
        }

        public IReadOnlyCollection<ConversionOperatorWithSyntax> ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<ConversionOperatorWithSyntax, IConversionOperatorSyntax>(
                    type.ConversionOperators,
                    conversionOperator => new ConversionOperatorWithSyntax(conversionOperator));
            }
        }

        public IReadOnlyCollection<NestedDelegateWithSyntax> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedDelegateWithSyntax, INestedDelegateSyntax>(
                    type.Delegates,
                    @delegate => new NestedDelegateWithSyntax(@delegate));
            }
        }

        public IReadOnlyCollection<NestedEnumWithSyntax> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumWithSyntax, INestedEnumSyntax>(
                    type.Enums,
                    @enum => new NestedEnumWithSyntax(@enum));
            }
        }

        public IReadOnlyCollection<EventPropertyWithSyntax> EventProperties
        {
            get
            {
                return new ReadOnlyNodeCollection<EventPropertyWithSyntax, IEventPropertySyntax>(
                    type.EventProperties,
                    eventProperty => new EventPropertyWithSyntax(eventProperty));
            }
        }

        public IReadOnlyCollection<FieldWithSyntax> Fields
        {
            get
            {
                return new ReadOnlyNodeCollection<FieldWithSyntax, IFieldSyntax>(
                    type.Fields,
                    field => new FieldWithSyntax(field));
            }
        }

        public IReadOnlyCollection<NestedInterfaceWithSyntax> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceWithSyntax, INestedInterfaceSyntax>(
                    type.Interfaces,
                    @interface => new NestedInterfaceWithSyntax(@interface));
            }
        }

        public IReadOnlyCollection<OperatorOverloadWithSyntax> OperatorOverloads
        {
            get
            {
                return new ReadOnlyNodeCollection<OperatorOverloadWithSyntax, IOperatorOverloadSyntax>(
                    type.OperatorOverloads,
                    operatorOverload => new OperatorOverloadWithSyntax(operatorOverload));
            }
        }

        public IReadOnlyCollection<NestedStructWithSyntax> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructWithSyntax, INestedStructSyntax>(
                    type.Structs,
                    @struct => new NestedStructWithSyntax(@struct));
            }
        }

        internal static TypeWithSyntax GetType(ITypeSyntax type)
        {
            return (TypeWithSyntax)GetBasicType(type);
        }
    }
}
