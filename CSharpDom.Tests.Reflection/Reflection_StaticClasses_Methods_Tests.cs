using CSharpDom.TestTarget.StaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithMethodWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithInternalMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithPublicMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPublicMethod));
        }
    }
}
