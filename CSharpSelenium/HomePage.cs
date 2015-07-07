using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace CSharpSelenium
{
	public class HomePage : AbstractPage
	{
		
		public HomePage (IWebDriver driver) : base(driver)
		{
			
		}

		public void enterSearch(String searchText){
			driver.FindElement (By.Id ("txtSearch")).SendKeys (searchText);
		}

		public  CategoryPage clickSearch(){
			driver.FindElement (By.ClassName ("go")).Click();
			return new CategoryPage (driver);
		}
	}
}

