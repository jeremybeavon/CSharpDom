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
            TestStruct(typeof(StructWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicEvent));
        }
    }
}
