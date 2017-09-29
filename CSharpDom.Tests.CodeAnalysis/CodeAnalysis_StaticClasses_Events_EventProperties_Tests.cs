using CSharpDom.TestTarget.StaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
