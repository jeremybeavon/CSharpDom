using CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
