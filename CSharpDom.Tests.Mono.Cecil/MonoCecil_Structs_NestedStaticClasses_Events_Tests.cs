using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicEvent));
        }
    }
}
