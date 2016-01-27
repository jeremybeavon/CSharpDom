using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestClassWithEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicAbstractEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Abstract,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public abstract event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.New,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewStaticEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewStatic,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new static event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewVirtualEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.NewVirtual,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public new virtual event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Override,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public override event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.SealedOverride,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public sealed override event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Static,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public static event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualEvent()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    InheritanceModifier = ClassMemberInheritanceModifier.Virtual,
                                    Type = new DelegateReference(typeof(EventHandler))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public virtual event EventHandler event1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithEventWithAccessorsWithNoStatements()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new CodeGenerationCollection<ClassEvent>()
                            {
                                new ClassEvent("event1")
                                {
                                    Type = new DelegateReference(typeof(EventHandler)),
                                    Accessors = new EventAccessors()
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
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
