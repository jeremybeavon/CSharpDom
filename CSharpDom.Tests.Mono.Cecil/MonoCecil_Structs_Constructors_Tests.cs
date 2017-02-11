using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithPublicConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicConstructor));
        }
    }
}
