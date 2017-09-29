using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
