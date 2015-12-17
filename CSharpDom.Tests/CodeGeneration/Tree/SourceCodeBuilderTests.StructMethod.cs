using System;
using CSharpDom.CodeGeneration.Tree;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.CodeGeneration.Tree
{
    public sealed partial class SourceCodeBuilderTests
    {
        [TestMethod]
        public void TestStructWithMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithInternalMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Internal,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    internal void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPrivateMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Private,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    private void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicNewMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("GetHashCode")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.New,
                                    ReturnType = new TypeReference(typeof(int))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public new int GetHashCode()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPublicNewStaticMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Equals")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.NewStatic,
                                    ReturnType = new TypeReference(typeof(bool))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public new static bool Equals()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicOverrideMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("GetHashCode")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.Override,
                                    ReturnType = new TypeReference(typeof(int))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public override int GetHashCode()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicStaticMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    InheritanceModifier = StructMethodInheritanceModifier.Static,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public static void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithPublicAsyncMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    Visibility = StructMemberVisibilityModifier.Public,
                                    IsAsync = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    public async void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithPartialMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    partial void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithAsyncPartialMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    IsAsync = true,
                                    IsPartial = true,
                                    ReturnType = new TypeReference(typeof(void))
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    async partial void Method1()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethod()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<T>()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWith2GenericParameters()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T1"),
                                        new GenericParameter("T2")
                                    }
                                }
                            }
                        }
                    }
                }
            }).Accept(builder);
            const string expectedText = @"struct TestStruct
{
    void Method1<T1, T2>()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWithClassGenericParameterConstraint()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<T>()
        where T : class
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWithStructGenericParameterConstraint()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<T>()
        where T : struct
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWithEmptyConstructorGenericParameterConstraint()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<T>()
        where T : new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWithBaseClassGenericParameterConstraint()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<T>()
        where T : BaseClass
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWith1InterfaceGenericParameterConstraint()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>()
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
    void Method1<T>()
        where T : ITestInterface
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWith2InterfaceGenericParameterConstraints()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>()
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
    void Method1<T>()
        where T : ITestInterface, ITestInterface2
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWith1GenericTypeGenericParameterConstraint()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("TParent"),
                                        new GenericParameter("TChild")
                                        {
                                            GenericParameterConstraints = new CodeGenerationCollection<GenericParameterReference>()
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
    void Method1<TParent, TChild>()
        where TChild : TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWith2GenericTypeGenericParameterConstraints()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<TGrandparent, TParent, TChild>()
        where TChild : TGrandparent, TParent
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWithStructAndInterfaceAndEmptyConstructorGenericParameterConstraints()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
                                    {
                                        new GenericParameter("T")
                                        {
                                            TypeConstraint = GenericParameterTypeConstraintModifier.Struct,
                                            InterfaceConstraints = new CodeGenerationCollection<InterfaceReference>()
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
    void Method1<T>()
        where T : struct, ITestInterface, new()
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithGenericMethodWith2GenericParameterConstraints()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    GenericParameters = new CodeGenerationCollection<GenericParameter>()
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
    void Method1<TKey, TValue>()
        where TKey : ITestInterface
        where TValue : TKey
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithMethodWithParameter()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
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
    void Method1(string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
        
        [TestMethod]
        public void TestStructWithMethodWithOutParameter()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = MethodParameterModifier.Out
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
    void Method1(out string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithMethodWithRefParameter()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference(typeof(string)),
                                            Modifier = MethodParameterModifier.Ref
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
    void Method1(ref string parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }

        [TestMethod]
        public void TestStructWithMethodWithParamsParameter()
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
                            Methods = new CodeGenerationCollection<StructMethod>()
                            {
                                new StructMethod("Method1")
                                {
                                    ReturnType = new TypeReference(typeof(void)),
                                    Parameters = new CodeGenerationCollection<MethodParameter>()
                                    {
                                        new MethodParameter("parameter1")
                                        {
                                            Type = new TypeReference("string[]"),
                                            Modifier = MethodParameterModifier.Params
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
    void Method1(params string[] parameter1)
    {
    }
}";
            builder.ToString().Should().Be(expectedText);
        }
    }
}
