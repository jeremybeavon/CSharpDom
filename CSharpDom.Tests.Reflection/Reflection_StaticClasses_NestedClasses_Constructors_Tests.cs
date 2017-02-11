using CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_StaticClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicConstructor));
        }
    }
}
