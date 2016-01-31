using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class CodeGenerationFileTests
    {
        [TestMethod]
        public void TestStructWithEvent()
        {
            const string expectedText = @"struct TestStruct
{
    event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new Collection<StructEvent>()
                            {
                                new StructEvent("event1")
                                {
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicEvent()
        {
            const string expectedText = @"struct TestStruct
{
    public event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new Collection<StructEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalEvent()
        {
            const string expectedText = @"struct TestStruct
{
    internal event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new Collection<StructEvent>()
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
            }).ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateEvent()
        {
            const string expectedText = @"struct TestStruct
{
    private event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new Collection<StructEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicStaticEvent()
        {
            const string expectedText = @"struct TestStruct
{
    public static event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new Collection<StructEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithEventWithAccessorsWithNoStatements()
        {
            const string expectedText = @"struct TestStruct
{
    event EventHandler event1
    {
        add { }
        remove { }
    }
}";             
(new CodeGenerationFile()
            {
                Structs =
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            Events = new Collection<StructEvent>()
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
