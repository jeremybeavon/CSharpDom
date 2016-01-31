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
        public void TestClassWithEvent()
        {
            const string expectedText = @"class TestClass
{
    event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
                            {
                                new ClassEvent("event1")
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
        public void TestClassWithPublicEvent()
        {
            const string expectedText = @"class TestClass
{
    public event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalEvent()
        {
            const string expectedText = @"class TestClass
{
    internal event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEvent()
        {
            const string expectedText = @"class TestClass
{
    protected internal event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedEvent()
        {
            const string expectedText = @"class TestClass
{
    protected event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateEvent()
        {
            const string expectedText = @"class TestClass
{
    private event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicAbstractEvent()
        {
            const string expectedText = @"class TestClass
{
    public abstract event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewEvent()
        {
            const string expectedText = @"class TestClass
{
    public new event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewStaticEvent()
        {
            const string expectedText = @"class TestClass
{
    public new static event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicNewVirtualEvent()
        {
            const string expectedText = @"class TestClass
{
    public new virtual event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicOverrideEvent()
        {
            const string expectedText = @"class TestClass
{
    public override event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicSealedOverrideEvent()
        {
            const string expectedText = @"class TestClass
{
    public sealed override event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicStaticEvent()
        {
            const string expectedText = @"class TestClass
{
    public static event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicVirtualEvent()
        {
            const string expectedText = @"class TestClass
{
    public virtual event EventHandler event1;
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithEventWithAccessorsWithNoStatements()
        {
            const string expectedText = @"class TestClass
{
    event EventHandler event1
    {
        add { }
        remove { }
    }
}";             
(new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Body = new ClassBody()
                        {
                            Events = new Collection<ClassEvent>()
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
            }).ToString().Should().Be(expectedText);
        }
    }
}
