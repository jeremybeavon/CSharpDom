﻿using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    [TestClass]
    public sealed class SourceCodeBuilderTests
    {
        [TestMethod]
        public void Test1UsingAnd1Namespace()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Usings =
                {
                    new UsingDeclaration("System")
                },
                Namespaces =
                {
                    new Namespace("Namespace1")
                }
            }).Accept(builder);
            const string expectedText = @"using System;

namespace Namespace1
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Visibility = TypeVisibilityModifier.Public
                    }
                }
            }).Accept(builder);
            const string expectedText = @"public class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Visibility = TypeVisibilityModifier.Internal
                    }
                }
            }).Accept(builder);
            const string expectedText = @"internal class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBaseClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        BaseClass = new ClassReference("BaseClass")
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass : BaseClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey"),
                            new GenericParameter("TValue")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TKey, TValue>
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameteTypeConstraintModifier.Class
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : class
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameteTypeConstraintModifier.Struct
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : struct
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                BaseClassConstraint = new ClassReference("BaseClass")
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : BaseClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface"),
                                    new InterfaceReference("ITestInterface2")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TParent, TChild>
    where TChild : TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TGrandparent"),
                            new GenericParameter("TParent"),
                            new GenericParameter("TChild")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TGrandparent"),
                                    new GenericParameterReference("TParent")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TGrandparent, TParent, TChild>
    where TChild : TGrandparent, TParent
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithClassAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("T")
                            {
                                TypeConstraint = GenericParameteTypeConstraintModifier.Class,
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                },
                                HasEmptyConstructorConstraint = true
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<T>
    where T : class, ITestInterface, new()
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        GenericParameters =
                        {
                            new GenericParameter("TKey")
                            {
                                InterfaceConstraints =
                                {
                                    new InterfaceReference("ITestInterface")
                                }
                            },
                            new GenericParameter("TValue")
                            {
                                GenericParameterConstraints =
                                {
                                    new GenericParameterReference("TKey")
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass<TKey, TValue>
    where TKey : ITestInterface
    where TValue : TKey
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestAbstractClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Abstract
                    }
                }
            }).Accept(builder);
            const string expectedText = @"abstract class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestSealedClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Sealed
                    }
                }
            }).Accept(builder);
            const string expectedText = @"sealed class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStaticClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        InheritanceModifier = TypeInheritanceModifier.Static
                    }
                }
            }).Accept(builder);
            const string expectedText = @"static class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInterface()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass : ITestInterface
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWith2Interfaces()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        Interfaces =
                        {
                            new InterfaceReference("ITestInterface"),
                            new InterfaceReference("ITestInterface2")
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass : ITestInterface, ITestInterface2
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPartialClass()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Classes =
                {
                    new Class("TestClass")
                    {
                        IsPartial = true
                    }
                }
            }).Accept(builder);
            const string expectedText = @"partial class TestClass
{
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithField()
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
                            Fields =
                            {
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPublicField()
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
                            Fields =
                            {
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Public,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    public string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithInternalField()
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
                            Fields =
                            {
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Internal,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    internal string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedInternalField()
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
                            Fields =
                            {
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.ProtectedInternal,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected internal string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithProtectedField()
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
                            Fields =
                            {
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Protected,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    protected string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestClassWithPrivateField()
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
                            Fields =
                            {
                                new ClassFieldDeclaration(new TypeReference("string"))
                                {
                                    Visibility = ClassMemberVisibilityModifier.Private,
                                    Fields =
                                    {
                                        new Field("field1")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"class TestClass
{
    private string field1;
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
