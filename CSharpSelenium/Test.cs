using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace CSharpSelenium
{
	[TestFixture ()]
	public class Test

	{
	
		IWebDriver driver;

		[TestFixtureSetUp]
		public void testSetUp(){
			driver = new SafariDriver ();
		}

		[Test (), Ignore]
		public void able_to_do_search ()
		{
			HomePage homePage = new HomePage (driver);
			homePage.navigateToAppRoot ();
			homePage.enterSearch ("red shoes");
			homePage.clickSearch ();
		}

		[Test ()]
		public void able_to_sort_the_product_by_high_to_low(){
			HomePage homePage = new HomePage (driver);
			homePage.navigateToAppRoot ();
			homePage.enterSearch ("red shoes");
			CategoryPage categoryPage = homePage.clickSearch ();
			categoryPage.sortBy ("Price high to low");
			Assert.AreEqual ("Price high to low" , categoryPage.sortBy ("Price high to low"));
		}
			
		[TestFixtureTearDown]
		public void testTearDown(){
			driver.Quit ();
		}				
			
	}
}

