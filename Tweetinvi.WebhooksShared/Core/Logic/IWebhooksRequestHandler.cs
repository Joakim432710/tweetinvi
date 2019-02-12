﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tweetinvi.WebhooksShared.Core.Logic
{
    public interface IWebhooksRequestInfoRetriever
    {
        string GetPath();
        IDictionary<string, string[]> GetQuery();
        IDictionary<string, string[]> GetHeaders();
    }

    public interface IWebhooksRequestHandler : IWebhooksRequestInfoRetriever
    {
        Task<string> GetJsonFromBody();
        void SetResponseStatusCode(int statusCode);
        void SetResponseContentType(string contentType);
        Task WriteInResponseAsync(string content);
    }
}