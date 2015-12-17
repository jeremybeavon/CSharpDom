using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructWithEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new CodeGenerationCollection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new CodeGenerationCollection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new CodeGenerationCollection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new CodeGenerationCollection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new CodeGenerationCollection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    IsStatic = true,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public static event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithEventWithAccessorsWithNoStatements()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new CodeGenerationCollection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Type = new DelegateReference(typeof(EventHandler)),
                                    Accessors = new EventAccessors()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    event EventHandler event1
    {
        add { }
        remove { }
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
