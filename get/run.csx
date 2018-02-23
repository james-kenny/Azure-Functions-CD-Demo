using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function");
    
    return req.CreateResponse(HttpStatusCode.OK, "Hello there");
}

