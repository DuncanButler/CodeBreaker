// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Codebreaker.Acceptance.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Code-breaker submits guess")]
    public partial class Code_BreakerSubmitsGuessFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Code-breaker_submits_guess.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Code-breaker submits guess", @"The codebreaker submits a guess of four numbers.
The game marks the guess with + and - signs

For each number in the guess that matches the number and
position of a number in the secret code, the mark includes one
+ sign.

For each number in the guess that matches the number but not the
position of a number in the secret code, the mark inclues one
- sign.", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("submit guess")]
        [NUnit.Framework.TestCaseAttribute("1234", "5555", "")]
        [NUnit.Framework.TestCaseAttribute("1234", "1555", "+")]
        [NUnit.Framework.TestCaseAttribute("1234", "2555", "-")]
        [NUnit.Framework.TestCaseAttribute("1234", "5254", "++")]
        [NUnit.Framework.TestCaseAttribute("1234", "5154", "+-")]
        [NUnit.Framework.TestCaseAttribute("1234", "2545", "--")]
        [NUnit.Framework.TestCaseAttribute("1234", "5234", "+++")]
        [NUnit.Framework.TestCaseAttribute("1234", "5134", "++-")]
        [NUnit.Framework.TestCaseAttribute("1234", "5134", "+--")]
        [NUnit.Framework.TestCaseAttribute("1234", "5123", "---")]
        [NUnit.Framework.TestCaseAttribute("1234", "1234", "++++")]
        [NUnit.Framework.TestCaseAttribute("1234", "1243", "++--")]
        [NUnit.Framework.TestCaseAttribute("1234", "1423", "+---")]
        [NUnit.Framework.TestCaseAttribute("1234", "4321", "----")]
        public virtual void SubmitGuess(string code, string guess, string mark)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("submit guess", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I am a codebreaker");
#line 15
 testRunner.And(string.Format("I did set the code to, {0}", code));
#line 16
 testRunner.When(string.Format("I attempt to submit a guess: {0}", guess));
#line 17
 testRunner.Then(string.Format("I should see on the screen \'{0}\'", mark));
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
