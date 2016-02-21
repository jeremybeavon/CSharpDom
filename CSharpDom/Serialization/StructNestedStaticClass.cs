using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructNestedStaticClass :
        IStructNestedStaticClass<
            AttributeGroup,
            IStructType,
            GenericParameterDeclaration,
            StaticClassEventCollection,
            StaticClassProperty,
            NestedStaticClassMethodCollection,
            StaticClassFieldCollection,
            StaticClassNestedClassCollection,
            StaticClassNestedDelegate,
            StaticClassNestedEnum,
            StaticClassNestedInterfaceCollection,
            StaticClassNestedStructCollection,
            StaticConstructor>
    {
        public StructNestedStaticClass()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new StaticClassNestedClassCollection();
            Delegates = new List<StaticClassNestedDelegate>();
            Enums = new List<StaticClassNestedEnum>();
            Events = new StaticClassEventCollection();
            Fields = new StaticClassFieldCollection();
            GenericParameters = new List<GenericParameterDeclaration>();
            Interfaces = new StaticClassNestedInterfaceCollection();
            Methods = new NestedStaticClassMethodCollection();
            Properties = new List<StaticClassProperty>();
            Structs = new StaticClassNestedStructCollection();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public StaticClassNestedClassCollection Classes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public List<StaticClassNestedDelegate> Delegates { get; set; }

        public List<StaticClassNestedEnum> Enums { get; set; }

        public StaticClassEventCollection Events { get; set; }

        public StaticClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public StaticClassNestedInterfaceCollection Interfaces { get; set; }

        public NestedStaticClassMethodCollection Methods { get; set; }

        public string Name { get; set; }

        public List<StaticClassProperty> Properties { get; set; }

        public StaticConstructor StaticConstructor { get; set; }

        public StaticClassNestedStructCollection Structs { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<StaticClassNestedDelegate> IHasDelegates<StaticClassNestedDelegate>.Delegates
        {
            get { return Delegates; }
        }

        IReadOnlyCollection<StaticClassNestedEnum> IHasEnums<StaticClassNestedEnum>.Enums
        {
            get { return Enums; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyCollection<StaticClassProperty> IHasProperties<StaticClassProperty>.Properties
        {
            get { return Properties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedStaticClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedStaticClassChildren(this, visitor);
        }
    }
}
