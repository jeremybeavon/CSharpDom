using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
