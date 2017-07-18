using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class InternalNestedStaticPartialClassWithCodeAnalysis<TClass> :
        EditableNestedStaticClass<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticPartialClassEventCollectionWithCodeAnalysis,
            NestedStaticPartialClassPropertyWithCodeAnalysis,
            NestedStaticPartialClassMethodCollectionWithCodeAnalysis,
            NestedStaticPartialClassFieldCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TClass> classType;
        private readonly NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly WrappedCollection<
            NestedStaticClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis> delegates;
        private readonly WrappedCollection<
            NestedStaticClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis> enums;
        private readonly NestedStaticPartialClassEventCollectionWithCodeAnalysis events;
        private readonly NestedStaticPartialClassFieldCollectionWithCodeAnalysis fields;
        private readonly WrappedCollection<
            NestedStaticClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis> interfaces;
        private readonly WrappedCollection<
            NestedStaticClassPropertyWithCodeAnalysis,
            NestedStaticPartialClassPropertyWithCodeAnalysis> properties;
        private readonly NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis structs;

        internal InternalNestedStaticPartialClassWithCodeAnalysis(InternalNestedStaticClassWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            classes = new NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis(classType.Classes);
            delegates = new WrappedCollection<NestedStaticClassNestedDelegateWithCodeAnalysis, NestedStaticPartialClassNestedDelegateWithCodeAnalysis>(
                classType.Delegates,
                parent => new NestedStaticPartialClassNestedDelegateWithCodeAnalysis(parent),
                child => child.InternalDelegate,
                value => classType.Delegates = value);
            enums = new WrappedCollection<NestedStaticClassNestedEnumWithCodeAnalysis, NestedStaticPartialClassNestedEnumWithCodeAnalysis>(
                classType.Enums,
                parent => new NestedStaticPartialClassNestedEnumWithCodeAnalysis(parent),
                child => child.InternalEnum,
                value => classType.Enums = value);
            events = new NestedStaticPartialClassEventCollectionWithCodeAnalysis(classType.Events);
            fields = new NestedStaticPartialClassFieldCollectionWithCodeAnalysis(classType.Fields);
            interfaces = new WrappedCollection<NestedStaticClassNestedInterfaceWithCodeAnalysis, NestedStaticPartialClassNestedInterfaceWithCodeAnalysis>(
                classType.Interfaces,
                parent => new NestedStaticPartialClassNestedInterfaceWithCodeAnalysis(parent),
                child => child.Interface,
                value => classType.Interfaces = value);
            properties = new WrappedCollection<NestedStaticClassPropertyWithCodeAnalysis, NestedStaticPartialClassPropertyWithCodeAnalysis>(
                classType.Properties,
                parent => new NestedStaticPartialClassPropertyWithCodeAnalysis(parent),
                child => child.Property,
                value => classType.Properties = value);
            structs = new NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis(classType.Structs);
        }

        public override IType DeclaringType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis Classes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<NestedStaticPartialClassNestedDelegateWithCodeAnalysis> Delegates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<NestedStaticPartialClassNestedEnumWithCodeAnalysis> Enums { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override NestedStaticPartialClassEventCollectionWithCodeAnalysis Events { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override NestedStaticPartialClassFieldCollectionWithCodeAnalysis Fields { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<NestedStaticPartialClassNestedInterfaceWithCodeAnalysis> Interfaces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override NestedStaticPartialClassMethodCollectionWithCodeAnalysis Methods { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<NestedStaticPartialClassPropertyWithCodeAnalysis> Properties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override StaticConstructorWithCodeAnalysis StaticConstructor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis Structs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
