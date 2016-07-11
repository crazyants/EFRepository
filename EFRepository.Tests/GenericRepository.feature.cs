﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EFRepository.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class GenericRepositoryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GenericRepository.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GenericRepository", "\tIn order to reduce the work of writing repository\r\n\tAs a programmer\r\n\tI would li" +
                    "ke to create a GenericRepository to process database related logic", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "GenericRepository")))
            {
                EFRepository.Tests.GenericRepositoryFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add data into database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void AddDataIntoDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add data into database should be success", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table1.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 7
 testRunner.Given("I have test datas", ((string)(null)), table1, "Given ");
#line 10
 testRunner.When("I use generic repository to add data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table2.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 12
 testRunner.Then("database should exists test datas", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add datalist into database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void AddDatalistIntoDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add datalist into database should be success", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table3.AddRow(new string[] {
                        "1",
                        "TestData"});
            table3.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 17
 testRunner.Given("I have test datas", ((string)(null)), table3, "Given ");
#line 21
 testRunner.When("I use generic repository to add datalist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table4.AddRow(new string[] {
                        "1",
                        "TestData"});
            table4.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 23
 testRunner.Then("database should exists test datas", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get datalist from database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void GetDatalistFromDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get datalist from database should be success", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table5.AddRow(new string[] {
                        "1",
                        "TestData"});
            table5.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 29
 testRunner.Given("database has test datas", ((string)(null)), table5, "Given ");
#line 33
 testRunner.When("I use generic repository get data list from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table6.AddRow(new string[] {
                        "1",
                        "TestData"});
            table6.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 34
 testRunner.Then("the data list I get should be", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get datalist from database with condition content should contains \"2\" should be s" +
            "uccess")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void GetDatalistFromDatabaseWithConditionContentShouldContains2ShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get datalist from database with condition content should contains \"2\" should be s" +
                    "uccess", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table7.AddRow(new string[] {
                        "1",
                        "TestData"});
            table7.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 40
 testRunner.Given("database has test datas", ((string)(null)), table7, "Given ");
#line 44
 testRunner.And("test datas content field should contains \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.When("I use generic repository get data list with condition from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table8.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 46
 testRunner.Then("the data list I get should be", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get data from database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void GetDataFromDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data from database should be success", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table9.AddRow(new string[] {
                        "1",
                        "TestData"});
            table9.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 51
 testRunner.Given("database has test datas", ((string)(null)), table9, "Given ");
#line 55
 testRunner.When("I use generic repository get data from database by id \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table10.AddRow(new string[] {
                        "1",
                        "TestData"});
#line 56
 testRunner.Then("the data list I get should be", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get data from database with condition content should contains \"2\" should be succe" +
            "ss")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void GetDataFromDatabaseWithConditionContentShouldContains2ShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data from database with condition content should contains \"2\" should be succe" +
                    "ss", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table11.AddRow(new string[] {
                        "1",
                        "TestData"});
            table11.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 61
 testRunner.Given("database has test datas", ((string)(null)), table11, "Given ");
#line 65
 testRunner.And("test datas content field should contains \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("I use generic repository get data from database with conditon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table12.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 67
 testRunner.Then("the data list I get should be", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update data which is exists in database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void UpdateDataWhichIsExistsInDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update data which is exists in database should be success", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table13.AddRow(new string[] {
                        "1",
                        "TestData"});
            table13.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 72
 testRunner.Given("database has test datas", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table14.AddRow(new string[] {
                        "1",
                        "TestData Modified"});
#line 76
 testRunner.And("the data I want to update is", ((string)(null)), table14, "And ");
#line 79
 testRunner.When("I use generic repository update data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table15.AddRow(new string[] {
                        "1",
                        "TestData Modified"});
            table15.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 81
 testRunner.Then("database should exists test datas", ((string)(null)), table15, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete data which is exists in database should be success")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GenericRepository")]
        public virtual void DeleteDataWhichIsExistsInDatabaseShouldBeSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete data which is exists in database should be success", ((string[])(null)));
#line 86
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table16.AddRow(new string[] {
                        "1",
                        "TestData"});
            table16.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 87
 testRunner.Given("database has test datas", ((string)(null)), table16, "Given ");
#line 91
 testRunner.When("I use generic repository delete data with id \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.And("I save the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Content"});
            table17.AddRow(new string[] {
                        "2",
                        "TestData 2"});
#line 93
 testRunner.Then("database should exists test datas", ((string)(null)), table17, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
