using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructBody
    {
        public StructBody()
        {
            Fields = new Collection<StructField>();
            Events = new Collection<StructEvent>();
            Properties = new Collection<StructProperty>();
            AutoProperties = new Collection<StructAutoProperty>();
            LambdaProperties = new Collection<StructLambdaProperty>();
            Indexers = new Collection<StructIndexer>();
            Methods = new Collection<StructMethod>();
            UnaryOperators = new Collection<UnaryOperator>();
            BinaryOperators = new Collection<BinaryOperator>();
            ConversionOperators = new Collection<ConversionOperator>();
            NestedClasses = new Collection<StructNestedClass>();
            NestedDelegates = new Collection<StructNestedDelegate>();
            NestedEnums = new Collection<StructNestedEnum>();
            NestedInterfaces = new Collection<StructNestedInterface>();
            NestedStructs = new Collection<StructNestedStruct>();
            ExplicitInterfaceEvents = new Collection<ExplicitInterfaceEvent>();
            ExplicitInterfaceIndexers = new Collection<ExplicitInterfaceIndexer>();
            ExplicitInterfaceMethods = new Collection<ExplicitInterfaceMethod>();
            ExplicitInterfaceProperties = new Collection<ExplicitInterfaceProperty>();
        }

        public Collection<StructField> Fields { get; set; }

        public Collection<StructEvent> Events { get; set; }

        public Collection<StructProperty> Properties { get; set; }

        public Collection<StructAutoProperty> AutoProperties { get; set; }

        public Collection<StructLambdaProperty> LambdaProperties { get; set; }

        public Collection<StructIndexer> Indexers { get; set; }

        public Collection<StructMethod> Methods { get; set; }

        public Collection<UnaryOperator> UnaryOperators { get; set; }

        public Collection<BinaryOperator> BinaryOperators { get; set; }

        public Collection<ConversionOperator> ConversionOperators { get; set; }

        public Collection<StructNestedClass> NestedClasses { get; set; }

        public Collection<StructNestedDelegate> NestedDelegates { get; set; }

        public Collection<StructNestedEnum> NestedEnums { get; set; }

        public Collection<StructNestedInterface> NestedInterfaces { get; set; }

        public Collection<StructNestedStruct> NestedStructs { get; set; }

        public StaticConstructor StaticConstructor { get; set; }

        public Collection<ExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }

        public Collection<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public Collection<ExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }

        public Collection<ExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
    }
}
