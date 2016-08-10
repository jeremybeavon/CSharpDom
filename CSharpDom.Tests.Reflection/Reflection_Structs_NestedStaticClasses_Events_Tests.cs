using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEvent));
        }
    }
}
