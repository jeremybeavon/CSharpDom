using CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
