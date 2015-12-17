using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructNestedDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestPublicStructNestedDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public delegate string TestStructNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestInternalStructNestedDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal delegate string TestStructNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestPrivateStructNestedDelegate()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(string))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private delegate string TestStructNestedDelegate();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith1GenericParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith2GenericParameters()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("TKey"),
                                        new GenericParameter("TValue")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TKey, TValue>();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Class
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : class;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithStructGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Struct
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : struct;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithEmptyConstructorGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            HasEmptyConstructorConstraint = true
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : new();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithBaseClassGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            BaseClassConstraint = new ClassReference("BaseClass")
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : BaseClass;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith1InterfaceGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : ITestInterface;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith2InterfaceGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : ITestInterface, ITestInterface2;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith1GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TParent, TChild>()
        where TChild : TParent;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith2GenericTypeGenericParameterConstraint()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
                                    GenericParameters =
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Struct,
                                            InterfaceConstraints =
                                            {
                                                new InterfaceReference("ITestInterface")
                                            },
                                            HasEmptyConstructorConstraint = true
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<T>()
        where T : struct, ITestInterface, new();
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWith2GenericParameterConstraints()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(string)),
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
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate string TestStructNestedDelegate<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey;
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string))
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(string parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithOutParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Out,
                                            Type = new TypeReference(typeof(string))
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(out string parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithRefParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Ref,
                                            Type = new TypeReference(typeof(string))
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(ref string parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructNestedDelegateWithParamsParameter()
        {
            SourceCodeBuilder builder = new SourceCodeBuilder();
            (new CodeGenerationFile()
            {
                Structs = new CodeGenerationCollection<Struct>()
                {
                    new Struct("TestStruct")
                    {
                        Body = new StructBody()
                        {
                            NestedDelegates = new CodeGenerationCollection<StructNestedDelegate>()
                            {
                                new StructNestedDelegate("TestStructNestedDelegate")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Modifier = MethodParameterModifier.Params,
                                            Type = new TypeReference("string[]")
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    delegate void TestStructNestedDelegate(params string[] parameter1);
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
