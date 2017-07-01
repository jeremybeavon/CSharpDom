using System;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.Serialization
{
    public sealed class StaticClass :
        IStaticClass<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            StaticClassEventCollection,
            StaticClassProperty,
            StaticClassMethodCollection,
            StaticClassFieldCollection,
            StaticClassNestedClassCollection,
            StaticClassNestedDelegate,
            StaticClassNestedEnum,
            StaticClassNestedInterface,
            StaticClassNestedStructCollection,
            StaticConstructor>
    {
        public StaticClass()
        {
            Attributes = new List<AttributeGroup>();
            Classes = new StaticClassNestedClassCollection();
            Delegates = new List<StaticClassNestedDelegate>();
            Enums = new List<StaticClassNestedEnum>();
            Events = new StaticClassEventCollection();
            Fields = new StaticClassFieldCollection();
            GenericParameters = new List<GenericParameterDeclaration>();
            Interfaces = new List<StaticClassNestedInterface>();
            Methods = new StaticClassMethodCollection();
            Properties = new List<StaticClassProperty>();
            Structs = new StaticClassNestedStructCollection();
        }

        public StaticClassEventCollection Events { get; set; }
        
        public StaticClassMethodCollection Methods { get; set; }

        public List<StaticClassProperty> Properties { get; set; }

        public List<AttributeGroup> Attributes { get; set; }

        public ClassReference BaseClass { get; set; }

        public StaticClassNestedClassCollection Classes { get; set; }
        
        public List<StaticClassNestedDelegate> Delegates { get; set; }
        
        public DocumentNotSupported Document
        {
            get { return null; }
        }

        public List<StaticClassNestedEnum> Enums { get; set; }

        public StaticClassFieldCollection Fields { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }
        
        public List<StaticClassNestedInterface> Interfaces { get; set; }
        
        public string Name { get; set; }

        public NamespaceNotSupported Namespace
        {
            get { return null; }
        }
        
        public ProjectNotSupported Project
        {
            get { return null; }
        }
        
        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public StaticConstructor StaticConstructor { get; set; }

        public StaticClassNestedStructCollection Structs { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }
        
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

        IReadOnlyCollection<StaticClassNestedInterface> IHasInterfaces<StaticClassNestedInterface>.Interfaces => Interfaces;

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClass(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassChildren(this, visitor);
        }
    }
}
