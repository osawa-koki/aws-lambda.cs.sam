using System.Collections.Generic;
using System.Text.Json;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace HelloWorld
{

  public class Function
  {
    public APIGatewayProxyResponse HelloGet(APIGatewayProxyRequest apigProxyEvent, ILambdaContext context)
    {
      return new APIGatewayProxyResponse
      {
        StatusCode = 200,
        Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } },
        Body = JsonSerializer.Serialize(new Dictionary<string, string>
        {
          { "message", "hello GET!!!" },
          { "error", null },
        }),
      };
    }

    public APIGatewayProxyResponse HelloPost(APIGatewayProxyRequest apigProxyEvent, ILambdaContext context)
    {
      return new APIGatewayProxyResponse
      {
        StatusCode = 200,
        Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } },
        Body = JsonSerializer.Serialize(new Dictionary<string, string>
        {
          { "message", "hello POST!!!" },
          { "error", null },
        }),
      };
    }

    public APIGatewayProxyResponse HelloPut(APIGatewayProxyRequest apigProxyEvent, ILambdaContext context)
    {
      return new APIGatewayProxyResponse
      {
        StatusCode = 200,
        Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } },
        Body = JsonSerializer.Serialize(new Dictionary<string, string>
        {
          { "message", "hello PUT!!!" },
          { "error", null },
        }),
      };
    }

    public APIGatewayProxyResponse HelloDelete(APIGatewayProxyRequest apigProxyEvent, ILambdaContext context)
    {
      return new APIGatewayProxyResponse
      {
        StatusCode = 200,
        Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } },
        Body = JsonSerializer.Serialize(new Dictionary<string, string>
        {
          { "message", "hello DELETE!!!" },
          { "error", null },
        }),
      };
    }
  }
}
