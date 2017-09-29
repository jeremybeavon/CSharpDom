using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
