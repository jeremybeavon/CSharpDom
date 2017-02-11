using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithConstructorWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithConstructorWith1ParameterUsingReflection()
        {
            TestStruct(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithPublicConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithPublicConstructor));
        }
    }
}
