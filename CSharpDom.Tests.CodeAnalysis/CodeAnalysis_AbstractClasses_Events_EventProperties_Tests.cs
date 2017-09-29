using CSharpDom.TestTarget.AbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualEventProperty));
        }
    }
}
