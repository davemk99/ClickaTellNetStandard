# ClickaTellNetStandard
Clickatell library for .NET Standard.It can work for ASP.NET Core,.NET 4.5,Windows Phone 8.0 and Windows Phone 8.1.
Below a simple example of using it.
```
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("to", "<phone number to>);
            dic.Add("content", "<your content here>);
            var result=Api.SendSMS("<your token here>",dic).Result;
```
