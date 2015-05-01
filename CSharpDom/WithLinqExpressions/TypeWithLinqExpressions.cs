using System.Collections.Generic;

namespace CSharpDom.WithLinqExpressions
{
    public abstract class TypeWithLinqExpressions : BasicTypeWithLinqExpressions
    {
        private readonly ITypeWithLinqExpressions type;

        public TypeWithLinqExpressions(ITypeWithLinqExpressions type)
            : base(type)
        {
            this.type = type;
        }

        public IReadOnlyCollection<NestedClassWithLinqExpressions> Classes
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassWithLinqExpressions, INestedClassWithLinqExpressions>(
                    type.Classes,
                    @class => new NestedClassWithLinqExpressions(@class));
            }
        }

        public IReadOnlyCollection<ConstructorWithLinqExpressions> Constructors
        {
            get
            {
                return new ReadOnlyNodeCollection<ConstructorWithLinqExpressions, IConstructorWithLinqExpressions>(
                    type.Constructors,
                    constructor => new ConstructorWithLinqExpressions(constructor));
            }
        }

        public IReadOnlyCollection<ConversionOperatorWithLinqExpressions> ConversionOperators
        {
            get
            {
                return new ReadOnlyNodeCollection<ConversionOperatorWithLinqExpressions, IConversionOperatorWithLinqExpressions>(
                    type.ConversionOperators,
                    conversionOperator => new ConversionOperatorWithLinqExpressions(conversionOperator));
            }
        }

        public IReadOnlyCollection<NestedDelegateWithLinqExpressions> Delegates
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedDelegateWithLinqExpressions, INestedDelegateWithLinqExpressions>(
                    type.Delegates,
                    @delegate => new NestedDelegateWithLinqExpressions(@delegate));
            }
        }

        public IReadOnlyCollection<NestedEnumWithLinqExpressions> Enums
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumWithLinqExpressions, INestedEnumWithLinqExpressions>(
                    type.Enums,
                    @enum => new NestedEnumWithLinqExpressions(@enum));
            }
        }

        public IReadOnlyCollection<EventPropertyWithLinqExpressions> EventProperties
        {
            get
            {
                return new ReadOnlyNodeCollection<EventPropertyWithLinqExpressions, IEventPropertyWithLinqExpressions>(
                    type.EventProperties,
                    eventProperty => new EventPropertyWithLinqExpressions(eventProperty));
            }
        }

        public IReadOnlyCollection<FieldWithLinqExpressions> Fields
        {
            get
            {
                return new ReadOnlyNodeCollection<FieldWithLinqExpressions, IFieldWithLinqExpressions>(
                    type.Fields,
                    field => new FieldWithLinqExpressions(field));
            }
        }

        public IReadOnlyCollection<NestedInterfaceWithLinqExpressions> Interfaces
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceWithLinqExpressions, INestedInterfaceWithLinqExpressions>(
                    type.Interfaces,
                    @interface => new NestedInterfaceWithLinqExpressions(@interface));
            }
        }

        public IReadOnlyCollection<OperatorOverloadWithLinqExpressions> OperatorOverloads
        {
            get
            {
                return new ReadOnlyNodeCollection<OperatorOverloadWithLinqExpressions, IOperatorOverloadWithLinqExpressions>(
                    type.OperatorOverloads,
                    operatorOverload => new OperatorOverloadWithLinqExpressions(operatorOverload));
            }
        }

        public IReadOnlyCollection<NestedStructWithLinqExpressions> Structs
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructWithLinqExpressions, INestedStructWithLinqExpressions>(
                    type.Structs,
                    @struct => new NestedStructWithLinqExpressions(@struct));
            }
        }

        internal static TypeWithLinqExpressions GetType(ITypeWithLinqExpressions type)
        {
            return (TypeWithLinqExpressions)GetBasicType(type);
        }
    }
}
