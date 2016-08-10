using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_NestedAbstractClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
