using System.Collections.Generic;

namespace CSharpDom.WithReflection
{
    public abstract class TypeWithReflection : BasicTypeWithReflection
    {
        private readonly ITypeWithReflection type;

        public TypeWithReflection(ITypeWithReflection type)
            : base(type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<NestedClassWithReflection> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassWithReflection, INestedClassWithReflection>(
                    type.Classes,
                    @class => new NestedClassWithReflection(@class));
            }
        }

        public IReadOnlyCollection<ConstructorWithReflection> Constructors
        {
            get
            {
                return new ReadOnlyNodeCollection<ConstructorWithReflection, IConstructorWithReflection>(
                    type.Constructors,
                    constructor => new ConstructorWithReflection(constructor));
            }
        }

        public IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<ConversionOperatorWithReflection, IConversionOperatorWithReflection>(
                    type.ConversionOperators,
                    conversionOperator => new ConversionOperatorWithReflection(conversionOperator));
            }
        }

        public IReadOnlyCollection<NestedDelegateWithReflection> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedDelegateWithReflection, INestedDelegateWithReflection>(
                    type.Delegates,
                    @delegate => new NestedDelegateWithReflection(@delegate));
            }
        }

        public IReadOnlyCollection<NestedEnumWithReflection> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumWithReflection, INestedEnumWithReflection>(
                    type.Enums,
                    @enum => new NestedEnumWithReflection(@enum));
            }
        }

        public IReadOnlyCollection<EventPropertyWithReflection> EventProperties
        {
            get
            {
                return new ReadOnlyNodeCollection<EventPropertyWithReflection, IEventPropertyWithReflection>(
                    type.EventProperties,
                    eventProperty => new EventPropertyWithReflection(eventProperty));
            }
        }

        public IReadOnlyCollection<FieldWithReflection> Fields
        {
            get
            {
                return new ReadOnlyNodeCollection<FieldWithReflection, IFieldWithReflection>(
                    type.Fields,
                    field => new FieldWithReflection(field));
            }
        }

        public IReadOnlyCollection<NestedInterfaceWithReflection> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceWithReflection, INestedInterfaceWithReflection>(
                    type.Interfaces,
                    @interface => new NestedInterfaceWithReflection(@interface));
            }
        }

        public IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get
            {
                return new ReadOnlyNodeCollection<OperatorOverloadWithReflection, IOperatorOverloadWithReflection>(
                    type.OperatorOverloads,
                    operatorOverload => new OperatorOverloadWithReflection(operatorOverload));
            }
        }

        public IReadOnlyCollection<NestedStructWithReflection> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructWithReflection, INestedStructWithReflection>(
                    type.Structs,
                    @struct => new NestedStructWithReflection(@struct));
            }
        }

        internal static TypeWithReflection GetType(ITypeWithReflection type)
        {
            return (TypeWithReflection)GetBasicType(type);
        }
    }
}
