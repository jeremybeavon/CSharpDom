using CSharpDom.TestTarget.SealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
