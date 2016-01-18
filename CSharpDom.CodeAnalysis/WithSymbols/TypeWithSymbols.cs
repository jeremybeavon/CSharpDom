using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public abstract class TypeWithSymbols : BasicTypeWithSymbols
    {
        private readonly ITypeWithSymbols type;

        public TypeWithSymbols(ITypeWithSymbols type)
            : base(type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<NestedClassWithSymbols> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassWithSymbols, INestedClassWithSymbols>(
                    type.Classes,
                    @class => new NestedClassWithSymbols(@class));
            }
        }

        public IReadOnlyCollection<ConstructorWithSymbols> Constructors
        {
            get
            {
                return new ReadOnlyNodeCollection<ConstructorWithSymbols, IConstructorWithSymbols>(
                    type.Constructors,
                    constructor => new ConstructorWithSymbols(constructor));
            }
        }

        public IReadOnlyCollection<ConversionOperatorWithSymbols> ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<ConversionOperatorWithSymbols, IConversionOperatorWithSymbols>(
                    type.ConversionOperators,
                    conversionOperator => new ConversionOperatorWithSymbols(conversionOperator));
            }
        }

        public IReadOnlyCollection<NestedDelegateWithSymbols> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedDelegateWithSymbols, INestedDelegateWithSymbols>(
                    type.Delegates,
                    @delegate => new NestedDelegateWithSymbols(@delegate));
            }
        }

        public IReadOnlyCollection<NestedEnumWithSymbols> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumWithSymbols, INestedEnumWithSymbols>(
                    type.Enums,
                    @enum => new NestedEnumWithSymbols(@enum));
            }
        }

        public IReadOnlyCollection<EventPropertyWithSymbols> EventProperties
        {
            get
            {
                return new ReadOnlyNodeCollection<EventPropertyWithSymbols, IEventPropertyWithSymbols>(
                    type.EventProperties,
                    eventProperty => new EventPropertyWithSymbols(eventProperty));
            }
        }

        public IReadOnlyCollection<FieldWithSymbols> Fields
        {
            get
            {
                return new ReadOnlyNodeCollection<FieldWithSymbols, IFieldWithSymbols>(
                    type.Fields,
                    field => new FieldWithSymbols(field));
            }
        }

        public IReadOnlyCollection<NestedInterfaceWithSymbols> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceWithSymbols, INestedInterfaceWithSymbols>(
                    type.Interfaces,
                    @interface => new NestedInterfaceWithSymbols(@interface));
            }
        }

        public IReadOnlyCollection<OperatorOverloadWithSymbols> OperatorOverloads
        {
            get
            {
                return new ReadOnlyNodeCollection<OperatorOverloadWithSymbols, IOperatorOverloadWithSymbols>(
                    type.OperatorOverloads,
                    operatorOverload => new OperatorOverloadWithSymbols(operatorOverload));
            }
        }

        public IReadOnlyCollection<NestedStructWithSymbols> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructWithSymbols, INestedStructWithSymbols>(
                    type.Structs,
                    @struct => new NestedStructWithSymbols(@struct));
            }
        }

        internal static TypeWithSymbols GetType(ITypeWithSymbols type)
        {
            return (TypeWithSymbols)GetBasicType(type);
        }
    }
}
