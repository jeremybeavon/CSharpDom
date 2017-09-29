using CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
