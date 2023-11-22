// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RestSharp;
Console.WriteLine("Hello, World!");

RestClient client = new RestClient();
RestRequest req1 = new RestRequest("https://localhost:7039/api/Name/authenticate", Method.Post);
req1.AddJsonBody(new
{
    username = "test1",
    password = "password1"
});
var respone1 = client.Execute(req1);
var token = JsonConvert.DeserializeObject<string>(respone1.Content);
Console.WriteLine(token);

RestRequest req2 = new RestRequest("https://localhost:7039/api/Name", Method.Get);
client.AddDefaultHeader("Authorization",$"Bearer {token}");

var respone2 = client.Execute(req2);
var content = respone2.Content;
Console.WriteLine(content);

Console.ReadLine();