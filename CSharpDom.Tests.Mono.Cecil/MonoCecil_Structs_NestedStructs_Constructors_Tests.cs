using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicConstructor));
        }
    }
}
