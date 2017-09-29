using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
