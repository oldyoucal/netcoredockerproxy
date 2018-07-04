using System;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DockerProxyCore.Test
{
	[TestClass]
	public class ProxyTest
	{
		private HttpClient _client;

		[TestInitialize]
		public void Init()
		{
			// Arrange 
			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", false)
				.Build();
			_client = new HttpClient {BaseAddress = new Uri(configuration["BaseApiAddress"]), Timeout = TimeSpan.FromMinutes(1)};
		}

		[TestMethod]
		public void CreatePaymentRequest_Request200Successfull()
		{
			//given an example of payment request
				
			var content = "{ \"payeePaymentReference\": \"0123456789\", \"callbackUrl\": \"https://example.com/api/swishcb/paymentrequests\", \"payerAlias\": \"4671234768\", \"payeeAlias\": \"1231181189\", \"amount\": \"100\", \"currency\": \"SEK\", \"message\": \"Kingston USB Flash Drive 8 GB\" }";

			// when submiting the request
			var response = _client.PostAsync("proxy", new StringContent(content, Encoding.Default, "application/json")).Result;

			// 
			Assert.IsTrue(response.IsSuccessStatusCode);
		}
	}
}