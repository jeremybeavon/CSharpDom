﻿using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractClassBody
    {
        public AbstractClassBody()
        {
            Fields = new Collection<ClassField>();
            Events = new Collection<ClassEvent>();
            Properties = new Collection<ClassProperty>();
            Indexers = new Collection<ClassIndexer>();
            Methods = new Collection<ClassMethod>();
            UnaryOperators = new Collection<UnaryOperator>();
            BinaryOperators = new Collection<BinaryOperator>();
            ConversionOperators = new Collection<ConversionOperator>();
            NestedClasses = new Collection<ClassNestedClass>();
            NestedDelegates = new Collection<ClassNestedDelegate>();
            NestedEnums = new Collection<ClassNestedEnum>();
            NestedInterfaces = new Collection<ClassNestedInterface>();
            NestedStructs = new Collection<ClassNestedStruct>();
            ExplicitInterfaceEvents = new Collection<ExplicitInterfaceEvent>();
            ExplicitInterfaceIndexers = new Collection<ExplicitInterfaceIndexer>();
            ExplicitInterfaceMethods = new Collection<ExplicitInterfaceMethod>();
            ExplicitInterfaceProperties = new Collection<ExplicitInterfaceProperty>();
        }

        public Collection<AbstractEvent> AbstractEvents { get; set; }

        public Collection<AbstractIndexer> AbstractIndexers { get; set; }

        public Collection<AbstractMethod> AbstractMethods { get; set; }

        public Collection<AbstractProperty> AbstractProperties { get; set; }

        public Collection<ClassField> Fields { get; set; }

        public Collection<ClassEvent> Events { get; set; }

        public Collection<ClassProperty> Properties { get; set; }

        public Collection<ClassIndexer> Indexers { get; set; }

        public Collection<ClassMethod> Methods { get; set; }

        public Collection<UnaryOperator> UnaryOperators { get; set; }

        public Collection<BinaryOperator> BinaryOperators { get; set; }

        public Collection<ConversionOperator> ConversionOperators { get; set; }

        public Collection<ClassNestedClass> NestedClasses { get; set; }

        public Collection<ClassNestedDelegate> NestedDelegates { get; set; }

        public Collection<ClassNestedEnum> NestedEnums { get; set; }

        public Collection<ClassNestedInterface> NestedInterfaces { get; set; }

        public Collection<ClassNestedStruct> NestedStructs { get; set; }

        public StaticConstructor StaticConstructor { get; set; }

        public Collection<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public Collection<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public Collection<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        public Collection<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
    }
}
