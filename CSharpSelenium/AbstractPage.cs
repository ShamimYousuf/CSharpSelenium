using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Safari;

namespace CSharpSelenium
{
	public class AbstractPage
	{
		public IWebDriver driver;

		public AbstractPage (IWebDriver driver)
		{
			this.driver = driver;
		}

		public HomePage navigateToAppRoot(){
			driver.Navigate ().GoToUrl ("http://www.asos.com");
			return new HomePage (driver);
		}

		public void quitDriver(){
			driver.Quit ();
		}

		public String getPageTitle(){
			return driver.Title;
		}
	}
}

